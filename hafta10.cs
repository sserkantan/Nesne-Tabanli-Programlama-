//27) ilk degerleri sırayla 7,3,6,0,9 olan bir dizi oluşturun. Küçükten büyük’e sıralayın.
int[] dizi = new int[5] { 7, 3, 6, 0, 9 };
Array.Sort(dizi); //diziyi küçükten büyüğe doğru sıralar
for (int i = 0; i <= 4; i++)
Console.WriteLine("{0}.elemanın değeri {1}", i, dizi[i]);
-----------------------------------------------------------------------------------------------------
//30) ilk degerleri sırayla 7,3,6,0,9 olan bir dizi oluşturun. Büyükten küçük’e sıralayın.
int[] dizi = new int[5] { 7, 3, 6, 0, 9 };
Array.Sort(dizi); //diziyi küçükten büyüğe doğru sıralar
Array.Reverse(dizi);//diziyi terine çevirir
for (int i = 0; i <= 4; i++)
Console.WriteLine("{0}.elemanın değeri {1}", i, dizi[i]);
-----------------------------------------------------------------------------------------------------
//33) ilk degerleri sırayla 7,3,6,0,9 olan bir dizi oluşturun. Teksayıların toplamını k ya yazın.
int[] dizi = new int[5] { 7, 3, 6, 0, 9 };
int toplam = 0;
for (int i = 0; i <= 4; i++)
if (dizi[i] % 2 == 1) toplam += dizi[i];
Console.WriteLine("tek sayıların toplamı {0}", toplam);
for (int i = 0; i <= 4; i++)
Console.WriteLine("{0}.elemanın değeri {1}", i, dizi[i]);
-----------------------------------------------------------------------------------------------------
//34) ilk degerleri sırayla 7,3,6,0,9 olan bir dizi oluşturun. 3 e tam bölünenlerin toplamını k ya yazın.
int[] dizi = new int[5] { 7, 3, 6, 0, 9 };
int toplam = 0;
for (int i = 0; i <= 4; i++)
if (dizi[i] % 3 == 0) toplam += dizi[i];
Console.WriteLine("tek sayıların toplamı {0}", toplam);
for (int i = 0; i <= 4; i++)
Console.WriteLine("{0}.elemanın değeri {1}", i, dizi[i]);
-----------------------------------------------------------------------------------------------------
//35) ilk degerleri sırayla 7,3,6,0,9 olan bir dizi oluşturun. 2 ye veya 3 e tam bölünenlerin toplamını k ya
yazın.
int[] dizi = new int[5] { 7, 3, 6, 0, 9 };
int toplam = 0;
for (int i = 0; i <= 4; i++)
if ((dizi[i] % 3 == 0) && (dizi[i] % 2 == 0)) toplam += dizi[i];
Console.WriteLine("tek sayıların toplamı {0}", toplam);
for (int i = 0; i <= 4; i++)
Console.WriteLine("{0}.elemanın değeri {1}", i, dizi[i]);
-----------------------------------------------------------------------------------------------------
//36) ilk degerleri sırayla 7,3,6,0,9 olan bir dizi oluşturun. Çiftsayıların ortalamasını k ya yazın.
int[] dizi = new int[5] { 7, 4, 6, 0, 9 };
int toplam = 0,s=0;
for (int i = 0; i <= 4; i++)
if(dizi[i]!=0)
if (dizi[i] % 2 == 0) { toplam += dizi[i]; s++; }
Console.WriteLine("çit sayıların ortalamasi {0}", toplam / (double)s);
for (int i = 0; i <= 4; i++)
Console.WriteLine("{0}.elemanın değeri {1}", i, dizi[i]);
-----------------------------------------------------------------------------------------------------
//37) ilk degerleri sırayla 7,3,6,0,9 olan bir dizi oluşturun. Değerleri 5 den büyük olanların adedini k ya
yazın.
int[] dizi = new int[5] { 7, 4, 6, 0, 9 };
int s=0;
for (int i = 0; i <= 4; i++)
if (dizi[i] >= 5) { s++; }
Console.WriteLine("5den büyük sayı sayısı {0}",s);
for (int i = 0; i <= 4; i++)
Console.WriteLine("{0}.elemanın değeri {1}", i, dizi[i]);
-----------------------------------------------------------------------------------------------------
//40) ilk degerleri sırayla 7,3,6,0,9 olan bir dizi oluşturun. İçinde 5 değeri varmı yokmu k (k nın tipi bool
olsun) ya yaz.
int[] dizi = new int[5] { 7, 4, 6, 0, 9 };
bool k = false;
for (int i = 0; i <= 4; i++)
if (dizi[i] == 6) k = true;
if (k) Console.WriteLine("dizi içinde 6 değeri var");
for (int i = 0; i <= 4; i++)
Console.WriteLine("{0}.elemanın değeri {1}", i, dizi[i]);
-----------------------------------------------------------------------------------------------------
//42) ilk degerleri sırayla 7,3,6,0,9 ve 9,0,7,3,6 olan iki dizi oluşturun. İki dizinin elamanları toplamını k ya
yaz.
int[] dizi1 = new int[5] { 7, 3, 6, 0, 9 };
int[] dizi2 = new int[5] { 9, 0, 7, 3, 6 };
int k=0;
for (int i = 0; i <= 4; i++)
k += dizi1[i] + dizi2[i];
Console.WriteLine("iki dizinin elemanları toplamı {0}",k);
Console.WriteLine("dizi1\tdizi2");
for (int i = 0; i <= 4; i++)
Console.WriteLine("{0}\t{1}", dizi1[i], dizi2[i]);
-----------------------------------------------------------------------------------------------------
//45) ilk degerleri sırayla 7,3,6,0,9 ve 0,0,0,0,0 olan iki dizi oluşturun. Birinci dizinin değerlerini ikinci diziye
koplayalayın.
int[] dizi1 = new int[5] { 7, 3, 6, 0, 9 };
int[] dizi2 = new int[5] { 0, 0, 0, 0, 0 };
for (int i = 0; i <= 4; i++)
dizi2[i] = dizi1[i];
Console.WriteLine("dizi1\tdizi2");
for (int i = 0; i <= 4; i++)
Console.WriteLine("{0}\t{1}", dizi1[i], dizi2[i]);
-----------------------------------------------------------------------------------------------------
//46) ilk degerleri sırayla 7,3,6,0,9 ve 0,0,0,0,0 olan iki dizi oluşturun. Birinci dizinin değerlerini ikinci diziye
tersinden(=ilk veri son veriye,…) koplayalayın.
/*
0-4
1-3
2-2
3-1
4-0
*/
int[] dizi1 = new int[5] { 7, 3, 6, 0, 9 };
int[] dizi2 = new int[5] { 0, 0, 0, 0, 0 };
for (int i = 0; i <= 4; i++)
dizi2[4 - i] = dizi1[i];
Console.WriteLine("dizi1\tdizi2");
for (int i = 0; i <= 4; i++)
Console.WriteLine("{0}\t{1}", dizi1[i], dizi2[i]);
-----------------------------------------------------------------------------------------------------
//49) ilk degerleri sırayla 7,3,6,0,9 ve 0,0,0,0,0 olan iki dizi oluşturun. İki dizinin değerlerini birbiriyle
değiştirin.
/*
swap(yer değiştirme) işlemi
a=5;
b=7;
c=a;
a=b;
b=c;
*/
int[] dizi1 = new int[5] { 7, 3, 6, 0, 9 };
int[] dizi2 = new int[5] { 0, 0, 0, 0, 0 };
int swap;
for (int i = 0; i <= 4; i++)
{
swap = dizi1[i];
dizi1[i] = dizi2[i];
dizi2[i] = swap;
}
Console.WriteLine("dizi1\tdizi2");
for (int i = 0; i <= 4; i++)
Console.WriteLine("{0}\t{1}", dizi1[i], dizi2[i]);
-----------------------------------------------------------------------------------------------------
//51) ilk degerleri sırayla 7,3,6,0,9 ve 8,1,4,7,5 olan iki dizi oluşturun. İki diziyide küçükten büyüğe
sıralayın
int[] dizi1 = new int[5] { 7, 3, 6, 0, 9 };
int[] dizi2 = new int[5] { 8, 1, 4, 7, 5 };
Array.Sort(dizi1);
Array.Sort(dizi2);
Console.WriteLine("dizi1\tdizi2");
for (int i = 0; i <= 4; i++)
Console.WriteLine("{0}\t{1}", dizi1[i], dizi2[i]);
-----------------------------------------------------------------------------------------------------
//52) ilk degerleri sırayla 7,3,6,0,9 ve 8,1,4,7,5 olan iki dizi oluşturun. İlk diziyi küçükten büyüğe, ikinci
diziyi büyükten küçüğü sıraya dizin.
int[] dizi1 = new int[5] { 7, 3, 6, 0, 9 };
int[] dizi2 = new int[5] { 8, 1, 4, 7, 5 };
Array.Sort(dizi1);
Array.Sort(dizi2);
Array.Reverse(dizi2);
Console.WriteLine("dizi1\tdizi2");
for (int i = 0; i <= 4; i++)
Console.WriteLine("{0}\t{1}", dizi1[i], dizi2[i]);
-----------------------------------------------------------------------------------------------------
/*68) Birbiriyle ilişkilendirilmiş, ad={"ali","veli","selami","ayşe","fatma"},
Vize1={10,70,30,60,90}, Vize2={15,70,90,35,80} ve final={80,30,50,10,10} dizileri
oluşturun. Öğrencilerin ortalamasını bakarak not ortalaması
(=0.25*vize1+0.25*vize2+0.5*final) en büyük olan kişinin ortalamasını k ya yaz.
*/
string[] ad = new string[5] { "ali", "veli", "selami", "ayşe", "fatma" };
int[] vize1 = new int[5] { 10, 70, 30, 60, 90 };
int[] vize2 = new int[5] { 15, 70, 90, 35, 80 };
int[] final = new int[5] { 80, 30, 50, 10, 10 };
double[] ortalama = new double[5];
for (int i = 0; i <= 4; i++)
ortalama[i] = vize1[i] * 0.25 + vize2[i] * 0.25 + final[i] * 0.50;
double enb = ortalama[0];
int konum = 0;
for (int i = 0; i <= 4; i++)
if (ortalama[i] > enb)
{
enb = ortalama[i];
konum = i;
}
for(int i = 0; i <= 4; i++)
Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", ad[i], vize1[i], vize2[i], final[i], ortalama[i]);
Console.WriteLine("en büyük not ortalaması");
Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", ad[konum], vize1[konum], vize2[konum], final[konum],
ortalama[konum]);
-----------------------------------------------------------------------------------------------------
/*73) Birbiriyle ilişkilendirilmiş, ad={"ali","veli","selami","ayşe","fatma"}, Vize1={10,70,30,60,90}, Vize2=
{15,70,90,35,80} ve final={80,30,50,10,10} dizileri oluşturun. Sınıf nin ortalamasını(not
ortalaması=0.25*vize1+0.25*vize2+0.5*final) k ya yaz.
*/
string[] ad = new string[5] { "ali", "veli", "selami", "ayşe", "fatma" };
int[] vize1 = new int[5] { 10, 70, 30, 60, 90 };
int[] vize2 = new int[5] { 15, 70, 90, 35, 80 };
int[] final = new int[5] { 80, 30, 50, 10, 10 };
double[] ortalama = new double[5];
for (int i = 0; i <= 4; i++)
ortalama[i] = vize1[i] * 0.25 + vize2[i] * 0.25 + final[i] * 0.50;
double toplam=0;
for (int i = 0; i <= 4; i++)
toplam += ortalama[i];
Console.WriteLine("sınıfın not ortalaması {0}", toplam / 5);
for(int i = 0; i <= 4; i++)
Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", ad[i], vize1[i], vize2[i], final[i], ortalama[i]);
-----------------------------------------------------------------------------------------------------