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
        /// <summary>
        /// Serializa un objeto de tipo T a binario.
        /// </summary>
        /// <param name="t">Objeto a serializar.</param>
        /// <param name="path">Ubicación del archivo binario.</param>
        public static void SerializeToBinary(T t, string path)
        {
            Stream fs = new FileStream(path, FileMode.Append);
            BinaryFormatter ser = new BinaryFormatter();

            ser.Serialize(fs, t);

            fs.Close();
        }

        /// <summary>
        /// Serializa un objeto de tipo T a XML.
        /// </summary>
        /// <param name="t">Objeto a serializar.</param>
        /// <param name="path">Ubicación del archivo XML.</param>
        public static void SerializeToXml(T t, string path)
        {
            XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8);
            XmlSerializer ser = new XmlSerializer(typeof(T));

            ser.Serialize(writer, t);            

            writer.Close();
        }
    }
}
