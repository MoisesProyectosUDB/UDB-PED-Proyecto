using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProyectoPED.Xml
{
    class Serializer<T>
    {
        public static T DeserializeString(string xml)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                StringReader reader = new StringReader(xml);

                var model = (T)serializer.Deserialize(reader);

                return model;
            }
            catch (Exception e)
            {
               

                return default;
            }
        }

        public static string SerializeToString(T model)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StringWriter writer = new StringWriter();

            serializer.Serialize(writer, model);

            return writer.ToString();
        }
    }
}
