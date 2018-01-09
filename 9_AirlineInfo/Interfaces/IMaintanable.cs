using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_AirlineInfo
{
    interface IMaintanable<T>
    {
        void Create(T obj);
        T Get(int key);
        void Update(T obj);
        void Delete(int key);
    }
}
