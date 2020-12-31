Console.Write("Adınızı giriniz ");
string isim;
isim=Console.ReadLine();
Console.WriteLine("yaşınızı giriniz");
string yas;
yas = Console.ReadLine();
Console.WriteLine("merhaba {0}, yaşın {1} olmuş",isim,yas);
//-------------------
int sayi = 10;
double sayi2 = 326.456;
char kr = 'a';
string metin = "serkan";
Console.WriteLine("{0} {1} {2} {3}", sayi, sayi2, kr, metin);
//-----------------
int a = 5,b=7;
int toplam;
toplam = a + b;
Console.WriteLine("sayıların toplamı {0}", toplam);
Console.WriteLine("{0} + {1} = {2}", a, b, toplam);
//----------------------
int sayi1, sayi2;
sayi1 = 5;
sayi2 = 6;
int toplam = sayi1 + sayi2;
Console.WriteLine("{0} ve {1} sayılarının toplamı {2}", sayi1, sayi2, toplam);
double ortalama = toplam / 2.0;
Console.WriteLine("{0} ve {1} sayılarının ortalaması {2}", sayi1, sayi2, ortalama);