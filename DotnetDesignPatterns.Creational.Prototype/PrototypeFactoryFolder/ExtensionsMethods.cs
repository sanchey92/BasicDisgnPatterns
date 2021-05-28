using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace DotnetDesignPatterns.Creational.Prototype.PrototypeFactoryFolder
{
    public static class ExtensionsMethods
    {
        public static T DeepCopy<T>(this T self)
        {
            using (var stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, self);
                stream.Seek(0, SeekOrigin.Begin);
                object copy = formatter.Deserialize(stream);
                return (T) copy;
            }
        }

        public static T DeepCopyXml<T>(this T self)
        {
            using (var stream = new MemoryStream())
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                xs.Serialize(stream, self);
                stream.Position = 0;
                return (T) xs.Deserialize(stream);
            }
        }
    }
}