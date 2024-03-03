

using Arayuzler;

ISifreci sifreci = new SifrelemeAlgo1();


//-------------------------------------
string str = "Btkakademi";
string sifreliMetin = sifreci.Sifrele(str);
Console.WriteLine(sifreliMetin);


Console.WriteLine(sifreci.SifreCoz(sifreliMetin));



using (DosyaIslemleri d = new DosyaIslemleri("deneme.txt"))
{

}//GC Dispose metodunu çağırır


