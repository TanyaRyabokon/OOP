using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    
    public class AstBodiesModel: ObservableCollection<AstronomicalBody>
    {
        private static object _threadLock = new Object();
        private static AstBodiesModel current = null;
 
        public static AstBodiesModel Current {
            get {
                lock (_threadLock)
                if (current == null)
                    current = new AstBodiesModel();
 
                return current;
            }
        }
 
        private AstBodiesModel() {
            Serialization file = new Serialization();
            List<AstronomicalBody> list = file.ReadFromFileToListOfObjects<AstronomicalBody>(@"D:\КПИ\ООП\OOP\lab5\WpfApplication1\data\out.json");
            foreach ( AstronomicalBody b in list)
            {
                Add(b);
            }
        }
 
        public void AddBody(String Name,
            float Weight, float X, float Y, float Z) {
            AstronomicalBody newBody = new AstronomicalBody(Name, Weight,
                X, Y, Z);
            Add(newBody);
        }

    }
}
