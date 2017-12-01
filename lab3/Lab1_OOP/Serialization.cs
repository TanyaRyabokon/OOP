using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Xml.Serialization;

namespace Lab1_OOP
{
    public class Serialization
    {
        // Deserialize  
        public List<T> ReadFromFileToListOfObjects<T>(string path)
        {
            string json = System.IO.File.ReadAllText(path);
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(List<T>));
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(json));
            var obj = (List<T>)ser.ReadObject(stream);
            return obj;
        }

        public void WriteToFileFromClass<T>(List<T> t, string path)
        {

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(List<T>));
            MemoryStream msObj = new MemoryStream();
            js.WriteObject(msObj, t);
            msObj.Position = 0;

            StreamReader sr = new StreamReader(msObj);

            string json = sr.ReadToEnd();

            sr.Close();
            msObj.Close();
            Console.WriteLine(json);
            File.WriteAllText(path, json);
        }

        public static void XmlSerialization(PlanetarySystem<AstronomicalBody> bodies)
        {
            XmlSerializer ser = new XmlSerializer(typeof(PlanetarySystem<AstronomicalBody>));
            Stream fs = new FileStream(@"D:\КПИ\ООП\OOP\lab3\Lab1_OOP\xmlserializer.xml", FileMode.Create);


                ser.Serialize(fs, bodies);

           
        }

        public static void XmlDeserialization(PlanetarySystem<AstronomicalBody> bodies)
        {
            XmlSerializer ser = new XmlSerializer(typeof(PlanetarySystem<AstronomicalBody>));
            using (FileStream fs = new FileStream("xmlserializer.xml", FileMode.OpenOrCreate))
            {
                PlanetarySystem<AstronomicalBody> new_bodies = (PlanetarySystem<AstronomicalBody>)ser.Deserialize(fs);
            }

        }
    }
}
