using OOP1;

Personel p1 = new Personel(1);
Personel p2 = new Personel(2);
BeyazYakaPersonel byp1 = new BeyazYakaPersonel(3);

p1.Ad = "Mustafa";
p1.Soyad = "KURAL";



p2.Ad = "Ali";
p2.Soyad = "Can";

byp1.Ad = "Ayşe";
byp1.Soyad = "Gül";

Console.WriteLine(byp1.BilgisiniGetir());

Console.WriteLine(p1.BilgisiniGetir());
Console.WriteLine(p2.BilgisiniGetir());
