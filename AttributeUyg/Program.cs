using AttributeUyg;
using System.Reflection;

Kitap kitap = new Kitap();
kitap.Id = 1;
kitap.Ad = "C# Programlama";
kitap.Yazar = "Aykut TAŞDELEN";
kitap.Sayfa = 345;


KitapBilgiYazdirici.Yazdir(kitap);

var metotlar = kitap.GetType().GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

foreach(MethodInfo mi in metotlar)
{
    if(mi.Name == "Temizle")
    {
        mi.Invoke(kitap, null);
    }
}

KitapBilgiYazdirici.Yazdir(kitap);
