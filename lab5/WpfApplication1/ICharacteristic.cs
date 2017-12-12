using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    interface ICharacteristic<T> where T : AstronomicalBody
    {
        float Rotation(T obj);
        float Diametr(T obj);
        string CompareCharacteristic(T obj);
    }
}
