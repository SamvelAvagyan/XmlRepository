using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Mic.VetEducation.Repository.XmlRepositories
{
    internal static class XmlHelper
    {
        public static void SaveToXml<T>(List<T> source, string fileName)
            where T : class, new()
        {
            var xmlSerializer = new XmlSerializer(typeof(List<T>));

            using (FileStream fStream = new FileStream(fileName, FileMode.Open))
            {
                xmlSerializer.Serialize(fStream, source);
            }
        }

        public static List<T> ReadFromXml<T>(string fileName)
            where T : class, new()
        {
            var xmlSerializer = new XmlSerializer(typeof(List<T>));

            using (FileStream fStream = new FileStream(fileName, FileMode.Open))
            {
                return (List<T>)xmlSerializer.Deserialize(fStream);
            }
        }
    }
}
