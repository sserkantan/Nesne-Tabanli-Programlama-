int[] sayilar = new int[5];
sayilar[0] = 5; //dizinin ilk elemanı
sayilar[1] = 7; //dizinin ikinci elemanı
sayilar[4] = 6; //diziinin son elemanı
int sayi = 5;
int[] dizi = new int[sayi];
int[] dizi2 = new int[4] { 3, 5, 9, 7 }; //4 elamnlı dizi oluşturup 3, 5, 9, 7 değerlerini diziye eleman olarak
atadık
int[] dizi3 = new int[] { 2, 5};// dizi ilk değer sayısı kadar elemana sahip olur
Console.WriteLine(dizi2.Length); //dizinin eleman sayısı
---------------------------------------------------------------------------------------------------
//1) 5 elamanlı bir dizi oluşturun, ilk elemanına 8 değeri atayın
int[] sayilar = new int[5];
sayilar[0] = 8;
---------------------------------------------------------------------------------------------------
//2) 5 elamanlı bir dizi oluşturun, kaç elemanda oluştuğunu k ya atayın
int[] sayilar = new int[5];
int k = sayilar.Length;
Console.WriteLine(k);
---------------------------------------------------------------------------------------------------
//3) 5 elamanlı bir dizi oluşturun, son elemanına 8 değeri atayın
int[] sayilar = new int[5];
sayilar[4] = 8;
sayilar[sayilar.Length - 1] = 8;
---------------------------------------------------------------------------------------------------
//4) 5 elamanlı bir dizi oluşturun, tum elemanlarına 8 değeri atayın
int[] sayilar = new int[5];
//1.yol
sayilar[0] = 8;
sayilar[1] = 8;
sayilar[2] = 8;
sayilar[3] = 8;
sayilar[4] = 8;
//2.yol
for (int i = 0; i <= 4; i++)
sayilar[i] = 8;
//diziyi ekrana yazdırma
for (int i = 0; i <= 4; i++)
Console.WriteLine("dizinin {0} elemanı {1}",i,sayilar[i]);
---------------------------------------------------------------------------------------------------
//5) 5 elamanlı bir dizi oluşturun, dizi numaralarını değerlerine atayın
int[] sayilar = new int[5];
//1.yol
sayilar[0] = 0;
sayilar[1] = 1;
sayilar[2] = 2;
sayilar[3] = 3;
sayilar[4] = 4;
//2.yol
for (int i = 0; i <= 4; i++)
sayilar[i] = i;
//diziyi ekrana yazdırma
for (int i = 0; i <= 4; i++)
Console.WriteLine("dizinin {0} elemanı {1}",i,sayilar[i]);
---------------------------------------------------------------------------------------------------
//6) 5 elemanlı bir dizi oluşturun, sıfırıncı elemanına 1 degeri, birinci elamanına 2… olmak üzere tüm
eleamlara bir arttırarak değer atayın.
int[] sayilar = new int[5];
//1.yol
sayilar[0] = 1;
sayilar[1] = 2;
sayilar[2] = 3;
sayilar[3] = 4;
sayilar[4] = 5;
//2.yol
for (int i = 0; i <= 4; i++)
sayilar[i] = i+1;
//diziyi ekrana yazdırma
for (int i = 0; i <= 4; i++)
Console.WriteLine("dizinin {0} elemanı {1}",i,sayilar[i]);
---------------------------------------------------------------------------------------------------
//7) 5 elamanlı bir dizi oluşturun, elamanlara sırayla 1,2,3,4,5 ilk değerleri atayın.
int[] sayilar = new int[5] { 1,2,3,4,5};
//diziyi ekrana yazdırma
for (int i = 0; i <= 4; i++)
Console.WriteLine("dizinin {0} elemanı {1}",i,sayilar[i]);
---------------------------------------------------------------------------------------------------
//8) ilk degerleri sırayla 5,5,5,5,5 olan bir dizi oluşturun. Sıfırıncı elamanına 4 değerini atayın.
int[] sayilar = new int[5] { 5,5,5,5,5};
sayilar[0] = 4;
//diziyi ekrana yazdırma
for (int i = 0; i <= 4; i++)
Console.WriteLine("dizinin {0} elemanı {1}",i,sayilar[i]);
---------------------------------------------------------------------------------------------------
//9) degerleri 5,5,5,5,5 olan diziyi oluşturun. Sıfırıncı elamana birinci elamanın değerini atayın.
int[] sayilar = new int[5] { 5,5,5,5,5};
sayilar[0] = sayilar[1];
//diziyi ekrana yazdırma
for (int i = 0; i <= 4; i++)
Console.WriteLine("dizinin {0} elemanı {1}",i,sayilar[i]);
---------------------------------------------------------------------------------------------------
//10) ilk degerleri 5,5,5,5,5 olan diziyi oluşturun. Değerlerinin toplamını son elemana atayın.
int[] sayilar = new int[5] { 5,5,5,5,5};
int toplam = 0;
for (int i = 0; i <= 4; i++)
toplam = toplam + sayilar[i];
sayilar[4] = toplam;
//diziyi ekrana yazdırma
for (int i = 0; i <= 4; i++)
Console.WriteLine("dizinin {0} elemanı {1}",i,sayilar[i]);
---------------------------------------------------------------------------------------------------
//11) ilk degerleri 2,6,8,4,7 olan diziyi oluşturun. Değerlerinin ortalamasını son elemana atayın.
double[] sayilar = new double[5] { 2,6,8,4,7};
double toplam = 0;
for (int i = 0; i <= 4; i++)
toplam = toplam + sayilar[i];
sayilar[4] = toplam/sayilar.Length;
//diziyi ekrana yazdırma
for (int i = 0; i <= 4; i++)
Console.WriteLine("dizinin {0} elemanı {1}",i,sayilar[i]);
---------------------------------------------------------------------------------------------------
//16) ilk degerleri sırayla 1,2,3,4,5 olan bir dizi oluşturun. Her Elemana değerinin bir fazlasını atayın.
double[] sayilar = new double[5] { 1, 2, 3, 4, 5 };
for (int i = 0; i <= 4; i++)
sayilar[i]++; //sayilar[i]=sayilar[i]+1;
//diziyi ekrana yazdırma
for (int i = 0; i <= 4; i++)
Console.WriteLine("dizinin {0} elemanı {1}",i,sayilar[i]);
---------------------------------------------------------------------------------------------------
//17) ilk degerleri sırayla 1,2,3,4,5 olan bir dizi oluşturun. Her Elemana değerinin yarısını atayın.
double[] sayilar = new double[5] { 1, 2, 3, 4, 5 };
for (int i = 0; i <= 4; i++)
sayilar[i] = sayilar[i] / 2;
//diziyi ekrana yazdırma
for (int i = 0; i <= 4; i++)
Console.WriteLine("dizinin {0} elemanı {1}",i,sayilar[i]);
---------------------------------------------------------------------------------------------------
//21) ilk degerleri sırayla 1,2,3,4,5 olan bir dizi oluşturun. Her elemana degerinin karesini atayın.
int[] sayilar = new int[5] { 1, 2, 3, 4, 5 };
for (int i = 0; i <= 4; i++)
sayilar[i] = sayilar[i] * sayilar[i];
//diziyi ekrana yazdırma
for (int i = 0; i <= 4; i++)
Console.WriteLine("dizinin {0} elemanı {1}",i,sayilar[i]);
---------------------------------------------------------------------------------------------------
//22) ilk degerleri sırayla 1,2,3,4,5 olan bir dizi oluşturun. Her elemana degerinin kupünü atayın.
double[] sayilar = new double[5] { 1, 2, 3, 4, 5 };
for (int i = 0; i <= 4; i++)
//math.pow üstel kuvvet hesaplar
sayilar[i] = Math.Pow(sayilar[i], 3);
//diziyi ekrana yazdırma
for (int i = 0; i <= 4; i++)
Console.WriteLine("dizinin {0} elemanı {1}",i,sayilar[i]);
---------------------------------------------------------------------------------------------------
//23) ilk degerleri sırayla 1,2,3,4,5 olan bir dizi oluşturun. Her elemana degerinin karekökünü atayın.
double[] sayilar = new double[5] { 1, 2, 3, 4, 5 };
//Math.Sqrt karekök hesaplar
for (int i = 0; i <= 4; i++)
sayilar[i] = Math.Sqrt(sayilar[i]);
//diziyi ekrana yazdırma
for (int i = 0; i <= 4; i++)
Console.WriteLine("dizinin {0} elemanı {1}",i,sayilar[i]);
---------------------------------------------------------------------------------------------------
//24) ilk degerleri sırayla 7,3,6,0,9 olan bir dizi oluşturun. En küçük elemanının değerini k ya yazın.
int[] sayilar = new int[5] { 7, 3, 6, 0, 9 };
int enkucuk;
enkucuk = sayilar[0];
//1.yol
if (sayilar[1] < enkucuk) enkucuk = sayilar[1];
if (sayilar[2] < enkucuk) enkucuk = sayilar[2];
if (sayilar[3] < enkucuk) enkucuk = sayilar[3];
if (sayilar[4] < enkucuk) enkucuk = sayilar[4];
//2.yol
for(int i=1;i<=4;i++)
if (sayilar[i] < enkucuk) enkucuk = sayilar[i];
Console.WriteLine("dizinin en küçük değeri {0}", enkucuk);
//diziyi ekrana yazdırma
for (int i = 0; i <= 4; i++)
Console.WriteLine("dizinin {0} elemanı {1}",i,sayilar[i]);
---------------------------------------------------------------------------------------------------
//24) ilk degerleri sırayla 7,3,6,0,9 olan bir dizi oluşturun. En büyük elemanının değerini k ya yazın.
int[] sayilar = new int[5] { 7, 3, 6, 0, 9 };
int enbuyuk;
enbuyuk = sayilar[0];
//1.yol
//2.yol
for(int i=1;i<=4;i++)
if (sayilar[i] > enbuyuk) enbuyuk = sayilar[i];
Console.WriteLine("dizinin en küçük değeri {0}", enbuyuk);
//diziyi ekrana yazdırma
for (int i = 0; i <= 4; i++)
Console.WriteLine("dizinin {0} elemanı {1}",i,sayilar[i]);
---------------------------------------------------------------------------------------------------