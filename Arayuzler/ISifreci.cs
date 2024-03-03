using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arayuzler
{
    public interface ISifreci
    {
        string Sifrele(string txt);
        string SifreCoz(string txt);
    }
}
