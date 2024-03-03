using HataVeFinal;

void DosyaAc()
{
    Console.WriteLine("dosya açıldı.....");
}

void DosyaOku()
{
    Console.WriteLine("dosya bilgileri okunuyor");
}

void DosyaYaz()
{
    Console.WriteLine("dosyaya bilgiler yazılıyor");
}
void DosyaKapat()
{
    Console.WriteLine("dosya kapandı.....");
}

try
{
    DosyaAc();

    DosyaOku();

    throw new MyException("Disk Hatası Oluştu");

    DosyaYaz(); // Hatadan dolayı burası çalışmaz
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
    return;
}
finally
{
    DosyaKapat();
}


