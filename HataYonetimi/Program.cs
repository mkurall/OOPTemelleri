
int SayiOku(string mesaj)
{
    int sayi = 0;

    bool hata = true;

    do
    {
        Console.Write(mesaj);

        try
        {
            sayi = Convert.ToInt32(Console.ReadLine());
            hata = false;
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Hatalı bir sayı girdiniz..");
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Çok büyük bir sayı girdiniz..");
        }


    } while (hata);

    return sayi;
}


int sayi1 = SayiOku("1.Sayıyı Girin:");


int sayi2 = SayiOku("2.Sayıyı Girin");

try
{
    int sonuc = sayi1 / sayi2;
    Console.WriteLine("Sonuç:" + sonuc);
}
catch(Exception)
{
    Console.Write("Hatalı İşlem. Bir sayı sıfıra bölünemez..");
}


