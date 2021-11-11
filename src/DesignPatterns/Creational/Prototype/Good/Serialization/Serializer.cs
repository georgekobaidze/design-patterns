using System.IO;
using System.Xml.Serialization;

namespace DesignPatterns.Creational.Prototype.Good.Serialization
{
    public static class Serializer
    {
        public static T DeepCopy<T>(this T self)
        {
            using var ms = new MemoryStream();
            var serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(ms, self);
            ms.Position = 0;
            return (T)serializer.Deserialize(ms);
        }
    }
}
