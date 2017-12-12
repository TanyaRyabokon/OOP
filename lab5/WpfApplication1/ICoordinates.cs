using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    interface ICoordinates<T> where T : AstronomicalBody
    {
        float X
        {
            get;
            set;
        }

        float Y
        {
            get;
            set;
        }
        float Z
        {
            get;
            set;
        }
        string Representation(float x, float y, float z);
    }
}
