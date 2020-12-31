//döngüler tekrar yapıları
// program içinde tekrarlanması gerekn işler döngüler yardımıyla gerçekleştirilir
/*
Console.WriteLine("amasya");
Console.WriteLine("amasya");
Console.WriteLine("amasya");
Console.WriteLine("amasya");
Console.WriteLine("amasya");
Console.WriteLine("amasya");
Console.WriteLine("amasya");
Console.WriteLine("amasya");
Console.WriteLine("amasya");
Console.WriteLine("amasya");
*/
// c# da döngüler while do..while for for..each
//döngü değişkeni
//döngü şartı
//adım miktarı
/*
*
while(şart)
{
Şart doğru olduğu sürece çalışacak komutlar
}
*/
int sayac=1; //döngünün başlangıç değeri
while(sayac<=10) //döngü şartı (şart doğru olduğu olduğu sürece döngü çalışır)
{
//tekrarlanacak olan komutlar
Console.WriteLine("amasya");
sayac = sayac + 1; //döngünün adım miktarı
}
--------------------------------------
//1-10 arası sayıları ekrana yazan program
int s = 1;
while(s<=10)
{
Console.WriteLine(s);
s++; //s=s+1;
}
--------------------------------------
//1-10 arası sayıların toplamını ekrana yazan program
int s = 1,toplam=0;
while(s<=10)
{
Console.WriteLine(s);
toplam = toplam + s;
s++; //s=s+1;
}
Console.WriteLine("sayilarin toplami {0}", toplam);
--------------------------------------
/*başlangıç ve bitişi girilen aralıktaki sayıların toplamını bulan program */
Console.Write("Başlangıç değerini giriniz ");
int baslangic = Convert.ToInt32(Console.ReadLine());
Console.Write("Bitiş değerini giriniz ");
int bitis = Convert.ToInt32(Console.ReadLine());
int s = baslangic,toplam=0;
while(s<=bitis)
{
Console.WriteLine(s);
toplam = toplam + s;
s++; //s=s+1;
}
Console.WriteLine("sayilarin toplami {0}", toplam);
--------------------------------------
// 1-10 arasındaki tek sayıları yazan program
int s;
//1.yol
s = 1;
while (s <= 10)
{
Console.WriteLine(s);
s=s+2;
}
//2.yol
s = 1;
while (s <= 10)
{
if (s % 2 == 1) Console.WriteLine(s);
s = s + 1;
}
--------------------------------------
// 0 girilene kadar girilen sayıların toplamını bulan program
int sayi=1, toplam = 0;
while (sayi != 0)
{
Console.Write("sayı giriniz ");
sayi = Convert.ToInt32(Console.ReadLine());
toplam += sayi; //toplam=toplam+sayi;
}
Console.WriteLine("girilen sayıların toplamı {0}", toplam);
--------------------------------------
/*
while (şart)
{
}
do
{
}while(şart)
*/
int sayi, toplam = 0;
do
{
Console.Write("Sayı Giriniz ");
sayi = Convert.ToInt32(Console.ReadLine());
toplam += sayi;
} while (sayi != 0);
Console.WriteLine("girilen sayıların toplamı {0}", toplam);
--------------------------------------
//kullanıcı adı ve şifre kontrolü
string kullanici_ad, sifre;
do
{
Console.Write("Kullanıcı adını giriniz ");
kullanici_ad = Console.ReadLine();
Console.Write("Şifre giriniz ");
sifre = Console.ReadLine();
} while (!((kullanici_ad == "serkan" ) && (sifre == "1234")));
Console.WriteLine("giriş başarılı");
------------------------------------