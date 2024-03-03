using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arayuzler
{
    public class DosyaIslemleri : IDisposable
    {
        public DosyaIslemleri(string file)
        {
            DosyayiAc(file);
        }

        private void DosyayiAc(string file)
        {
            Console.WriteLine("Dosya açıldı: " + file);
        }

        private void DosyaKapat()
        {
            Console.WriteLine("Kaydet");
            Console.WriteLine("Dosya kapatıldı");
        }

        public void Dispose()
        {
            DosyaKapat();
        }
    }
}
