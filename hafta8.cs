//10dan 1e kadar olan sayıları yazan program
//while döngüsü
int sayi = 10;
while(sayi>=1)
{
Console.WriteLine(sayi);
sayi--;
}
//do..while döngüsü
sayi = 10;
do
{
Console.WriteLine(sayi);
sayi--;
} while (sayi >= 1);
//for döngüsü
//for(döngü değişkeni=başlangıç değeri; döngü şartı; artış miktarı)
for(sayi = 10; sayi >= 1; sayi--)
{
Console.WriteLine(sayi);
}
-----------------------------------------------------------------------------------------
//girilen bir sayının asal sayı olup olmadığını bulan program
//Bir veya kendisinden başka TAM BÖLENİ olmayan sayıya ASAL sayı denir
/*
3%3=0
3%2=1
3%1=0 sadece 1'e ve 3'e tam bölündüğünden 3 sayısı asaldır
4%4=0
4%3=1
4%2=0
4%1=0 1,2,4'e tam bölündüğü için asal değildir.
*/
int s = 0;
Console.Write("sayı giriniz ");
int sayi = Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=sayi;i++)
{
if (sayi % i == 0) s++;
}
if (s == 2) Console.WriteLine("girilen sayı asal sayıdır");
else Console.WriteLine("girilen sayı asal değildir");
-----------------------------------------------------------------------------------------
//1-100 arasında 3'e ve 5'e bölünen sayı sayısını bulan program
int s = 0;
for(int i=1;i<=100;i++)
{
if (i % 3 == 0 && i % 5 == 0)
{
s++;
Console.WriteLine(i);
}
}
Console.WriteLine("1-100 arasında 3'e ve 5'e bölünen {0} sayı var",s);
-----------------------------------------------------------------------------------------
//iç içe döngüler
int n=0;
for(int i=1;i<=4;i++) //dıştaki döngü
{
for(int j=1;j<=3;j++) //içteki döngü
{
n++;
Console.WriteLine("i={0} j={1} n={2}", i, j, n);
}
}
-----------------------------------------------------------------------------------------
/*
Aşağıdaki çıktıyı oluşturen programı yazınız
*
**
***
****
*****
*/
for(int i=1;i<=5;i++)
{
for (int j = 1; j <= i; j++)
Console.Write("*");
Console.WriteLine();
}
-----------------------------------------------------------------------------------------
/*
Aşağıdaki çıktıyı oluşturen programı yazınız
*****
****
***
**
*
*/
for (int i=5;i>=1;i--)
{
for (int j = 1; j <= i; j++)
Console.Write("*");
Console.WriteLine();
}
-----------------------------------------------------------------------------------------
for (int i = 1; i <= 10; i++)
for (int j = 1; j <= 10; j++)
Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
-----------------------------------------------------------------------------------------
//continue ve break deyimleri
Console.WriteLine("break");
for(int i=1;i<=5;i++)
{
if (i == 3) break;
Console.WriteLine(i);
}
Console.WriteLine("continue");
for (int i = 1; i <= 5; i++)
{
if (i == 3) continue;
Console.WriteLine(i);
}
-----------------------------------------------------------------------------------------
//1-10 arası tek sayıları bulan program
for (int i = 1; i <= 10; i=i+2)
{
Console.WriteLine(i);
}
for (int i = 1; i <= 10; i++)
{
if (i % 2 == 1) Console.WriteLine(i);
}
for (int i = 1; i <= 10; i++)
{
if (i%2==0) continue;
Console.WriteLine(i);
}
-----------------------------------------------------------------------------------------
//Girilen 10 sayının en büyük, en küçük, pozitif sayı sayısı ve
//pozitif sayıların ortalamasını bulan program
int i, sayi, enb, enk, pss=0, pst=0;
double pso;
Console.Write("1. sayıyı giriniz : ");
sayi = Convert.ToInt32(Console.ReadLine());
enb = sayi;
enk = sayi;
if (sayi > 0) { pss++; pst += sayi; }
for(i=2;i<=10;i++)
{
Console.Write("{0}. sayıyı giriniz : ", i);
sayi = Convert.ToInt32(Console.ReadLine());
if (sayi > enb) enb = sayi;
if (sayi < enk) enk = sayi;
if(sayi>0)
{
pss++; //pss=pss+1;
pst += sayi; //pst=pst+sayi;
}
}
pso = pst / (double)pss;
Console.WriteLine("en büyük sayı {0}", enb);
Console.WriteLine("en küçük sayı {0}", enk);
Console.WriteLine("Pozitif sayı sayısı {0}", pss);
Console.WriteLine("Pozitif sayıların toplamı {0}", pst);
Console.WriteLine("Pozitif sayıların ortalaması {0}", pso);
-----------------------------------------------------------------------------------------
//Haftanın sorusu
//1'den 10'a kadar olan sayıları ve bu sayıların karelerini ekrana yazan program
//ÖRN:
// 1 1
// 2 4
// 3 9
// 4 16
// ....
//10 100
-----------------------------------------------------------------------------------------