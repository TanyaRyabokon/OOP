using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_OOP
{
    public interface IComparable<T>
    {
        int CompareTo(T obj);
    }
}
