using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTanimlama
{
    class Personel
    {
        public Cinsiyet Cinsiyet { get; set; }
        public Gunler CalistigiGunler { get; set; }


        public void EkranaYaz()
        {
            Console.WriteLine("Cinsiyet: " + (int)Cinsiyet);
            Console.WriteLine("Calidtigi Gunler: " + (int)CalistigiGunler);
        }

    }
}
