int sayi;
sayi = 5;
double sayi2;
sayi2 = sayi; //bilinçsiz tür dönüşümü
sayi = (int)sayi2; //bilinçli tür dönüşümü
sayi = Convert.ToInt32(sayi2); // Convert sınıfı ile tür dönüşümü
----------------------
string deger;
Console.Write("bir sayı giriniz ");
deger=Console.ReadLine();
int sayi;
sayi = Convert.ToInt32(deger);
Console.Write("bir sayı giriniz ");
int sayi2 = Convert.ToInt32(Console.ReadLine());
int toplam = sayi + sayi2;
Console.WriteLine("girilen sayıların toplamı {0}", toplam);
---------------------
//girilen vize final notuna göre ortalama hesaplayan program
// Ağırlıklı ortalama = vize %40 + final %60
// vize*40/100 -> vize*4/10 -> vize*0.4
int vize, final;
Console.Write("vize notunu giriniz ");
vize = Convert.ToInt32(Console.ReadLine());
Console.Write("final notunu giriniz ");
final = Convert.ToInt32(Console.ReadLine());
double ortalama = vize * 0.4 + final * 0.6;
Console.Write("girilen notların ortalaması {0}", ortalama);
---------------------
//silindirin hacmini hesaplayan program
//hacim=pi*yarıcapın karesi * yukseklik
Console.Write("yarıçap değerini giriniz ");
int yaricap = Convert.ToInt32(Console.ReadLine());
Console.Write("yükseklik değerini giriniz ");
int yukseklik= Convert.ToInt32(Console.ReadLine());
double hacim = 3.14 * yaricap * yaricap * yukseklik;
Console.WriteLine("ölçüleri girilen silindirin hacmi {0}", hacim);
--------------------
//üçgenin alanını hesaplayan program
// alan=taban*yukseklik/2
Console.Write("taban uzunluk değerini giriniz ");
int taban = Convert.ToInt32(Console.ReadLine());
Console.Write("yükseklik değerini giriniz ");
int yukseklik = Convert.ToInt32(Console.ReadLine());
double alan = taban * yukseklik / 2;
Console.WriteLine("ölçüleri girilen üçgenin alanı {0}", alan);