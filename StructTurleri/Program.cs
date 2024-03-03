
using StructTurleri;
using System.Data;

MyClass myClass = new MyClass();
myClass.Value = 10;


MyStruct myStruct = new MyStruct();
myStruct.Value = 20;

MyClass myClass2 = myClass;
MyStruct myStruct2 = myStruct;

void IslemYap1(MyClass nesne)
{
    nesne.Value = 0;
    Console.WriteLine("Islem Yap1: " + nesne.Value);
}

void IslemYap2(MyStruct nesne)
{
    nesne.Value = 0;
    Console.WriteLine("Islem Yap2: " + nesne.Value);
}



Console.WriteLine("myclass ilk değeri: " + myClass.Value);
Console.WriteLine("mystruct ilk değeri: " + myStruct.Value);

IslemYap1(myClass);

IslemYap2(myStruct);

Console.WriteLine("myclass son değeri: " + myClass.Value);
Console.WriteLine("mystruct son değeri: " + myStruct.Value);