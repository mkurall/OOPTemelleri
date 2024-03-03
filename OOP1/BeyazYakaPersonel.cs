using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class BeyazYakaPersonel : Personel
    {
        public bool YuksekLisansVarMi { get; set; }
        public string Departman { get; set; }
        public int YabanciDilSayisi { get; set; }
        public BeyazYakaPersonel(int id) 
        {
            base.id = id;
        }

        public override string BilgisiniGetir()
        {
            return $"Beyaz Yaka Personel: {Id} - {Ad} {Soyad}";
        }
    }
}
