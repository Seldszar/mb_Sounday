using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace MusicBeePlugin
{
    public partial class Plugin
    {
        private MusicBeeApiInterface mbApiInterface;
        private Settings settings;

        private readonly PluginInfo about = new PluginInfo();
        private readonly HttpClient client = new HttpClient();

        public PluginInfo Initialise(IntPtr apiInterfacePtr)
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            mbApiInterface = new MusicBeeApiInterface();
            mbApiInterface.Initialise(apiInterfacePtr);

            about.PluginInfoVersion = PluginInfoVersion;
            about.Name = "Sounday";
            about.Description = "Yet Another Tracking Plugin";
            about.Author = "Seldszar";
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
            return false;
        }

        public void SaveSettings()
        {
            // ...
        }

        public void ReceiveNotification(string sourceFileUrl, NotificationType type)
        {
            switch (type)
            {
                case NotificationType.PluginStartup:
                case NotificationType.TrackChanged:
                    SendRequest();
                    break;
            }
        }

        private void LoadSettings()
        {
            string dataPath = mbApiInterface.Setting_GetPersistentStoragePath();
            string settingsFilePath = Path.Combine(dataPath, $"{about.Name}.json");
            string settingsContent = File.ReadAllText(settingsFilePath);

            settings = JsonConvert.DeserializeObject<Settings>(settingsContent);
        }

        private async void SendRequest()
        {
            Track? currentTrack = GetCurrentTrack();

            try
            {
                string payload = JsonConvert.SerializeObject(new
                {
                    Track = currentTrack,
                });

                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, settings.Path);
                StringContent content = new StringContent(payload, Encoding.UTF8, "application/json");

                request.Content = content;

                if (!string.IsNullOrEmpty(settings.Token))
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", settings.Token);

                await client.SendAsync(request);
            }
            catch { }
        }

        private Track? GetCurrentTrack()
        {
            string trackTitle = mbApiInterface.NowPlaying_GetFileTag(MetaDataType.TrackTitle);
            string artist = mbApiInterface.NowPlaying_GetFileTag(MetaDataType.Artist);
            string album = mbApiInterface.NowPlaying_GetFileTag(MetaDataType.Album);

            if (string.IsNullOrEmpty(trackTitle))
                return null;

            return new Track
            {
                Album = album,
                Artist = artist,
                Title = trackTitle,
            };
        }
    }
}
