using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTanimlama
{
    enum Cinsiyet
    {
        Erkek = 0,
        Kadin = 1,
        BelirtmekIstemiyorum = 2,
    }

    [Flags]
    enum Gunler
    {
        Pazartesi = 0,
        Sali = 1,
        Carsamba = 2,
        Persembe = 4,
        Cuma = 8,
        Cumartesi = 16,
        Pazar = 32,
        HaftaIci = Pazartesi | Sali | Carsamba | Persembe | Cuma,
        HaftaSonu = Cumartesi | Pazar,
    }
}
