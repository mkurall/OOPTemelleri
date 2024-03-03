using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arayuzler
{
    public class SifrelemeAlgo2 : ISifreci
    {
        public string SifreCoz(string txt)
        {
            string result = "";

            for (int i = 0; i < txt.Length; i++)
            {
                int tmp = txt[i];
                tmp -= 5;

                result += (char)tmp;
            }

            return result;
        }

        public string Sifrele(string txt)
        {
            string result = "";

            for (int i = 0; i < txt.Length; i++)
            {
                int tmp = txt[i];
                tmp += 5;

                result += (char)tmp;
            }

            return result;
        }
    }
}
