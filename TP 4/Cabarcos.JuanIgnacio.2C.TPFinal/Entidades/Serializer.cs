using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public static class Serializer<T> where T : class, new()
    {
        public static void SerializeToBinary(T t, string path)
        {
            Stream fs = new FileStream(path, FileMode.Append);
            BinaryFormatter ser = new BinaryFormatter();

            ser.Serialize(fs, t);

            fs.Close();
        }

        public static T DeserializeFromBinary(string path)
        {
            Stream fs = new FileStream(path, FileMode.Open);
            BinaryFormatter ser = new BinaryFormatter();

            T aux = (T)ser.Deserialize(fs);

            fs.Close();

            return aux;
        }

        public static void SerializeToXml(T t, string path)
        {
            XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8);
            XmlSerializer ser = new XmlSerializer(typeof(T));

            ser.Serialize(writer, t);

            writer.Close();
        }

        public static T DeserializeFromXml(string path)
        {
            XmlTextReader reader = new XmlTextReader(path);
            XmlSerializer ser = new XmlSerializer(typeof(T));

            T aux = (T)ser.Deserialize(reader);

            reader.Close();

            return aux;
        }
    }
}
