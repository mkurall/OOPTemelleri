using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeUyg
{
    [Yazdir]
    public class Kitap
    {
        public int Id { get; set; }
        [Yazdirma]
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public int Sayfa { get; set; }

        private int Yil { get; set; }

        private void Temizle()
        {
            Id = 0;
            Ad = "";
            Yazar = "";
            Sayfa = 0;
        }
    }
}
