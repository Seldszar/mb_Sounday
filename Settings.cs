using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace MusicBeePlugin
{
    [DataContract(Name = "settings")]
    public class Settings
    {
        public string FilePath { get; set; }

        [DataMember]
        private string requestMethod;

        public string RequestMethod
        {
            get => requestMethod ?? "POST";
            set => requestMethod = value;
        }

        [DataMember]
        private string requestUri;

        public string RequestUri
        {
            get => requestUri ?? "";
            set => requestUri = value;
        }

        [DataMember]
        private Dictionary<string, string> headers;

        public Dictionary<string, string> Headers
        {
            get => headers ?? new Dictionary<string, string>();
            set => headers = value;
        }

        [DataMember]
        private string mediaType;

        public string MediaType
        {
            get => mediaType ?? "application/json";
            set => mediaType = value;
        }

        [DataMember]
        private string content;

        public string Content
        {
            get => content ?? "{\r\n  \"title\": \"{title}\",\r\n  \"artist\": \"{artist}\",\r\n  \"album\": \"{album}\"\r\n}";
            set => content = value;
        }

        public static Settings GetInstance(string filePath)
        {
            Settings newSettings;

            try
            {
                newSettings = Load(filePath);
            }
            catch
            {
                newSettings = new Settings();
            }

            newSettings.FilePath = filePath;

            return newSettings;
        }

        private static Settings Load(string filePath)
        {
            using (var stream = File.OpenRead(filePath))
            {
                var serializer = new DataContractSerializer(typeof(Settings));

                return serializer.ReadObject(stream) as Settings;
            }
        }

        public void Save()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(FilePath));

            XmlWriterSettings writerSettings = new XmlWriterSettings
            {
                NewLineHandling = NewLineHandling.Entitize,
            };

            using (var writer = XmlWriter.Create(FilePath, writerSettings))
            {
                var serializer = new DataContractSerializer(GetType());

                serializer.WriteObject(writer, this);
                writer.Flush();
            }
        }
    }
}
