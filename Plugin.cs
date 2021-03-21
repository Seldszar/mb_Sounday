using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace MusicBeePlugin
{
    public partial class Plugin
    {
        private MusicBeeApiInterface mbApiInterface;
        private Settings settings;
        private SettingsWindow settingsWindow;

        private readonly PluginInfo about = new PluginInfo();
        private readonly HttpClient client = new HttpClient();

        private bool isSending = false;

        public PluginInfo Initialise(IntPtr apiInterfacePtr)
        {
            mbApiInterface = new MusicBeeApiInterface();
            mbApiInterface.Initialise(apiInterfacePtr);

            about.PluginInfoVersion = PluginInfoVersion;
            about.Name = "Sounday";
            about.Description = "Yet another customizable scrobbling plugin for MusicBee.";
            about.Author = "Alexandre Breteau";
            about.TargetApplication = "";
            about.Type = PluginType.General;
            about.VersionMajor = 1;
            about.VersionMinor = 0;
            about.Revision = 0;
            about.MinInterfaceVersion = MinInterfaceVersion;
            about.MinApiRevision = MinApiRevision;
            about.ReceiveNotifications = (ReceiveNotificationFlags.PlayerEvents | ReceiveNotificationFlags.TagEvents);
            about.ConfigurationPanelHeight = 0;

            LoadSettings();

            return about;
        }

        public bool Configure(IntPtr panelHandle)
        {
            settingsWindow = new SettingsWindow(this, settings);
            settingsWindow.Show();

            return true;
        }

        public void SaveSettings()
        {
            // ...
        }

        public void ReceiveNotification(string sourceFileUrl, NotificationType type)
        {
            switch (type)
            {
                case NotificationType.TrackChanged:
                case NotificationType.PlayStateChanged:
                    if (mbApiInterface.Player_GetPlayState() == PlayState.Playing)
                        SendRequest();

                    break;
            }
        }

        private void LoadSettings()
        {
            string storagePath = mbApiInterface.Setting_GetPersistentStoragePath();
            string filePath = Path.Combine(mbApiInterface.Setting_GetPersistentStoragePath(), $"{about.Name}.settings");

            settings = Settings.GetInstance(filePath);
        }

        private async void SendRequest()
        {
            if (isSending)
                return;

            isSending = true;

            while (isSending)
            {
                try
                {
                    if (string.IsNullOrEmpty(settings.RequestUri))
                        return;

                    string payload = Regex.Replace(settings.Content, @"{(\w+):(\w+)}", match =>
                    {
                        switch (match.Groups[1].Value)
                        {
                            case "property":
                                {
                                    if (Enum.TryParse(match.Groups[2].Value, out FilePropertyType field))
                                        return HttpUtility.JavaScriptStringEncode(mbApiInterface.NowPlaying_GetFileProperty(field));

                                    break;
                                }

                            case "tag":
                                {
                                    if (Enum.TryParse(match.Groups[2].Value, out MetaDataType field))
                                        return HttpUtility.JavaScriptStringEncode(mbApiInterface.NowPlaying_GetFileTag(field));

                                    break;
                                }
                        }

                        return match.Value;
                    });

                    HttpRequestMessage request = new HttpRequestMessage(new HttpMethod(settings.RequestMethod), settings.RequestUri);
                    StringContent content = new StringContent(payload, Encoding.UTF8, settings.MediaType);

                    request.Content = content;

                    foreach (var pair in settings.Headers)
                        request.Headers.Add(pair.Key, pair.Value);

                    var response = await client.SendAsync(request);

                    if (response.IsSuccessStatusCode)
                        isSending = false;
                }
                catch
                {
                    await Task.Delay(3000);
                }
            }
        }
    }
}
