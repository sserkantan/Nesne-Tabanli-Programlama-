//girilen sayının tek veya çift olduğunu bulan program
// 5 % 2 = 1 8 % 2 = 0 2ye bölümden kalan 1se tek sayı, 0sa çift sayı
//
Console.Write("sayı giriniz ");
int sayi = Convert.ToInt32(Console.ReadLine());
if (sayi % 2 == 0) Console.WriteLine("girilen sayı çift");
else Console.WriteLine("girilen sayı tek");
---------------------------
/* 18.Bir işletme çalışanlarına tckimlik nolarının son hanesine göre ödeme
yapmaktadır.Ödeme günleri şu şekilde belirlenmektedir.
Eğer tckimlik numarasının son hanesi tek ise ödeme pazartesi günü,
çift ise çarşamba günü yapılmaktadır. Buna göre personelin girilen tc kimlik numarasına
göre ödeme gününü bulan program.
*/
Console.Write("TCNO giriniz ");
long sayi = Convert.ToInt64(Console.ReadLine());
if (sayi % 2 == 0) Console.WriteLine("ÖDEME ÇARŞAMBA");
else Console.WriteLine("ÖDEME PAZARTESİ");
------------------------------
/* Bir dersin not sistemi şöyledir: Dersin üç sınavının notları T1, T2 ve T3'dür.
* Final notu bu üç notun ortalamasıdır.
*
* FİNAL ORTALAMASI= T1 %25 + T2 %25 + T3 %50
*
* Yalnız, T3'ün ağırlığı %50'dir,
* T1 ve T2'nin ağırlıkları %25'erdir.
*
* EĞER(FİNAL ORTALAMASI >= 60 ) İSE "G" YAZ DeĞİLSE "K" YAZ
*
* Eğer bu final notu 60 veya daha yüksekse
* dersin harf notu (G) olmakta ve öğrenci dersi geçmektedir. Eğer final notu 60'dan
* düşükse harf notu (K) olmaktadır ve öğrenci kalmaktadır. Klavyeden T1, T2 ve T3'ü
* okuyup final notunu ve harf notunu yazdıran bir program hazırlayınız.
*/
Console.Write("T1 notunu giriniz ");
int t1 = Convert.ToInt32(Console.ReadLine());
Console.Write("T2 notunu giriniz ");
int t2 = Convert.ToInt32(Console.ReadLine());
Console.Write("T3 notunu giriniz ");
int t3 = Convert.ToInt32(Console.ReadLine());
double ortalama = t1 * 0.25 + t2 * 0.25 + t3 * 0.5;
Console.Write("Final not ortalaması {0} harf notu ", ortalama);
if (ortalama >= 60) Console.WriteLine("G");
else Console.WriteLine("K");
---------------------------------
// Kalvyeden girilen 1-5 arası sayının okunuşunu yazan program
Console.Write("1-5 arası sayı giriniz ");
int sayi = Convert.ToInt32(Console.ReadLine());
if (sayi == 1) Console.WriteLine("bir");
if (sayi == 2) Console.WriteLine("iki");
if (sayi == 3) Console.WriteLine("üç");
if (sayi == 4) Console.WriteLine("dört");
if (sayi == 5) Console.WriteLine("beş");
/*SWITCH komutu tamsayı veya metin/karakter türündeki bir değişkenin değerine göre
programda istenilen case çalıştırılır.
switch(değişken)
{
case değer: çalıştırılacak komut/komutlar break;
case değer: çalıştırılacak komut/komutlar break;
case değer: çalıştırılacak komut/komutlar break;
....
default : çalıştırılacak komut/komutlar break;
}
*/
switch(sayi)
{
case 1: Console.WriteLine("bir"); break;
case 2: Console.WriteLine("iki"); break;
case 3: Console.WriteLine("üç"); break;
case 4: Console.WriteLine("dört"); break;
case 5: Console.WriteLine("beş"); break;
default: Console.WriteLine("sayı 1-5 arasında değil ");break;
}
----------------------------
DateTime tarih;
tarih = DateTime.Now;
int gun = Convert.ToInt32(tarih.DayOfWeek);
//gun =1 pazartesi 2 salı ..... 7 pazar
string gunisim = "";
switch(gun)
{
case 1:gunisim = "pazartesi";break;
case 2: gunisim = "salı"; break;
case 3: gunisim = "çarşamba"; break;
case 4: gunisim = "perşembe"; break;
case 5: gunisim = "cuma"; break;
case 6: gunisim = "cumartesi"; break;
case 7: gunisim = "pazar"; break;
}
Console.WriteLine("{0} {1}", tarih.ToShortDateString(), gunisim);
------------------------------
// girilen iki kenar uzunluğuna göre şeklin kare veya dikdörtgen olduğunu bulan program
// kare iki kenarın eşit
//dikdörtgen iki kenarın farklı olması
Console.Write("birinci kenarı giriniz ");
int kenar1 = Convert.ToInt32(Console.ReadLine());
Console.Write("ikinci kenarı giriniz ");
int kenar2 = Convert.ToInt32(Console.ReadLine());
// EĞER (kenar1==kenar2) İSE "kare" yaz DEĞİLSE "dikdörtgen" yaz
if (kenar1 == kenar2) Console.WriteLine("kare");
else Console.WriteLine("dikdörtgen");
------------------------
/* -Bir elektrik dağıtım şirketi abonelerine ait harcamayı şu şekilde
* hesaplamaktadır.
0 - 50kw - 1TL
50kw -150kw 1,5 TL
150kw ve üzeri 2 TL
Buna göre girilen harcama bilgisine göre ödenecek tutarı % 18 kdv dahil hesaplayan akış diyagramını çiziniz.
HArcama miktarı : 40
40*1 =40
40*1.18= 47.2
ödeme tutarı : 47.2
*/
Console.Write("harcama miktarı : ");
int harcama = Convert.ToInt32(Console.ReadLine());
double katsayi=0;
if (harcama > 0 && harcama <= 50) katsayi = 1;
if (harcama > 50 && harcama <= 150) katsayi = 1.5;
if (harcama > 150) katsayi = 2;
double odeme = harcama * katsayi * 1.18;
Console.WriteLine("odeme miktari {0}", odeme);
------------------------
/*
Bir firma satış tutarına bağlı olarak indirim oranını aşağıdaki gibi belirlemektedir. Eğer satış tutarı 50 TL nin
altında ise indirim yapılmamaktadır.
50 TL – 100 TL arası %2 indirim
100 TL – 200 TL arası %4 indirim
200 TL ve üzeri %6 indirim
Buna göre girilen satış tutarına göre indirim tutarı ve ödenecek miktarın ne kadar olacağını bulan programın akış
diyagramını çiziniz.
*/

Console.Write("harcama miktarı : ");
int harcama = Convert.ToInt32(Console.ReadLine());
double indirim;
if (harcama < 50) indirim = 0;
else if (harcama < 100) indirim = harcama * 0.02;
else if (harcama < 200) indirim = harcama * 0.04;
else indirim = harcama * 0.06;
Console.WriteLine("{0} indirim ile {1} ödeme yapılacak", indirim, harcama - indirim);
-----------------------------
/*
1- Bir elektrik dağıtım şirketi abonelerine ait harcamayı şu şekilde hesaplamaktadır.
Müşteriler 3 grupta incelenmektedir.
Abone Türü Normal Zamlı
Mesken:1 0-50kw - 1TL 50kw ve üzeri 1,5 TL
İşyeri:2 0-150kw – 1,5TL 150kw ve üzeri 2 TL
Sanayi:3 0-100kw - 0,75TL 100kw ve üzeri 1 TL
Buna göre girilen harcama bilgisine göre ödenecek tutarı %18 kdv dahil
hesaplayan program
Abone türünü giriniz( 1-mesken 2-işyeri 3-sanayi):
tuketimi giriniz (kwh) :
*/
Console.Write("Abone türünü giriniz( 1-mesken 2-işyeri 3-sanayi): ");
int abone = Convert.ToInt32(Console.ReadLine());
Console.Write("tuketimi giriniz (kwh) : ");
int tuketim = Convert.ToInt32(Console.ReadLine());
double katsayi=0;
if (abone == 1)
if (tuketim < 50) katsayi = 1; else katsayi = 1.5;
if (abone == 2)
if (tuketim < 150) katsayi = 1.5; else katsayi = 2;
if (abone == 3)
if (tuketim < 100) katsayi = 0.75; else katsayi = 1;
double odeme = katsayi * tuketim * 1.18;
Console.WriteLine("odenecek tutar {0}", odeme);