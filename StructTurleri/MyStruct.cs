using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructTurleri
{
    public struct MyStruct
    {
        public int Value { get; set; }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
