using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelSiniflar
{
    public class Math<T>  
    {
        public string Birlestir(T s1, T s2)
        {
            return s1.ToString() + s2.ToString();
        }
    }
}
