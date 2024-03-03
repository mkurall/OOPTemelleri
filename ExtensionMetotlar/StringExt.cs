using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMetotlar
{
    public static class StringExt
    {
        public static string ToSentenceCase(this string text)
        {
            string result = "";

            for(int i = 0; i < text.Length; i++)
            {
                char ch = text[i];

                if (i == 0) //cümlenin başı, ilk karakter
                    result += Char.ToUpper(ch);
                else if (text[i - 1] == '.')
                    result += Char.ToUpper(ch);
                else
                    result += ch;//Bunu büyütmeye gerek yok
            }

            return result;
        }

        public static int Pow(this int n, int p)
        {
            int result = n;
            for(int i = 1;i<p;i++)
                result *= n;
            return result;
        }
    }
}
