using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttributeUyg
{
    public static class KitapBilgiYazdirici
    {
        public static void Yazdir(Kitap kitap)
        {
            Type type =  kitap.GetType();
            Console.WriteLine("sınıf Türü:" + type.ToString());

            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            Console.WriteLine("Properties------");
            foreach (PropertyInfo property in properties)
            {
                

                var attrList = property.GetCustomAttributes(typeof(YazdirmaAttribute));

                if(attrList.Count() == 0)
                {
                    Console.WriteLine($"{property.Name}:" + property.GetValue(kitap,null));
                }


            }

            


            /*
            Console.WriteLine("Id:" + kitap.Id);
            Console.WriteLine("Ad:" + kitap.Ad);
            Console.WriteLine("Yazar:" + kitap.Yazar);
            Console.WriteLine("Sayfa:" + kitap.Sayfa);
            */
        }
    }
}
