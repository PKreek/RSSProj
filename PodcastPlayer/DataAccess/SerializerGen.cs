using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataAccessLayer
{
    internal class Serializer<T>
    {
        private string fileName;
        public Serializer(string fName)
        {
            fileName = fName+".xml";
        }
        public void Serialize(List<T> list)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
            using (FileStream xmlOut =
                new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(xmlOut, list);
            }
        }

        public List<T> Deserialize()
        {
            List<T> listan;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
            using (FileStream xmlIn =
                new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                listan = (List<T>)xmlSerializer.Deserialize(xmlIn);
            }
            return listan;
        }
    }
}
