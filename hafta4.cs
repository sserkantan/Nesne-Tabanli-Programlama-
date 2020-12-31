aktarır a=a*b;
Console.WriteLine("a *= b; {0}", a);
---------------------------------
/* EĞER (if) Komutu
* if(koşul)
* ŞART DOĞRU İSE YAPILACAK İŞLEM
* else
* ŞART YANLIŞ İSE YAPILACAK İŞLEM
* koşulun true yada false olmasına göre yapıalcak işlem belirlenir.
* else bölümü her karşılaştırmada kullanılmak zorunda değil
*
*
* if(koşul)
* {
* ŞART DOĞRU İSE YAPILACAK İŞLEMLER
* }
* else
* {
* ŞART YANLIŞ İSE YAPILACAK İŞLEMLER
* }
*
*/
int x = 5, y = 7;
if (x < y) // 5<7 olduğundan TRUE değeri üretildi
Console.WriteLine("x değeri y değerinden küçük");//karşılaştırma doğru olduğunda çalışır
else
Console.WriteLine("x değeri y değerinden küçük değil");//karşılaştırma yanlış olduğunda çalışır
----------------------------------
//İki sayıdan büyük olandan küçük olanı çıkartan program
Console.Write("birinci sayıyı giriniz ");
int s1 = Convert.ToInt32(Console.ReadLine());
Console.Write("ikinci sayıyı giriniz ");
int s2 = Convert.ToInt32(Console.ReadLine());
int sonuc;
if (s1 > s2)
{
sonuc = s1 - s2;
Console.WriteLine("ilk sayı büyük sayılar arası fark {0}",sonuc);
}
else
{
sonuc = s2 - s1;
Console.WriteLine("ikinci sayı büyük sayılar arası fark {0}", sonuc);
}
---------------------------
//vize ve final ortalaması 60dan küçük ise "başarısız" değilse "başarılı" yazan program
int vize, final;
Console.Write("vize notunu giriniz ");
vize = Convert.ToInt32(Console.ReadLine());
Console.Write("final notunu giriniz ");
final = Convert.ToInt32(Console.ReadLine());
double ortalama = vize * 0.4 + final * 0.6;
Console.Write("girilen notların ortalaması {0}", ortalama);
if (ortalama < 60)
Console.WriteLine("dersten başarısız");
else
Console.WriteLine("dersten başarılı");
----------------------
/* değişkentürü değişkenin adı
* 5 tamsayı
* int sayi;
* sayi=5;
*
* console.write() ekrana çıktı verir
* console.writeLine() ekrana çıktı verir
* Console.Write("serkan"); ekrana serkan yazar
* Console.Write(sayi); sayi değişkeninin değerini ekrana yazar.
* Console.Readline(); ekrandan değer okumak için kullanılan komut
* Bu komut string (metin) türünde değer okuyor.
*
* değişken türlerini birbirine çevirmek için Convert komutu kullanılır.
* Convert.ToInt32 -> herhangi bir türü tamsayıya çevirir.
* Convert.ToDouble -> herhangi bir türü ondalıklı sayıya çevirir
* Convert.ToString -> herhangi bir türü metin(string) türüne çevirir.
*
*
*/
Console.Write(" bir sayı giriniz"); // ekrana "bir sayı giriniz" yazar
int sayi; //tamsayı türünde sayi adında değişken tanımlar.
string okunan_deger; //metin türünde okunan_deger adında değişken tanımlar.
okunan_deger = Console.ReadLine(); //klavyeden girilen değeri okunan_deger değişkenine aktarır
sayi = Convert.ToInt32(okunan_deger); //okunan_deger metin tütündeki değeri tamsayıya çevirip sayı
değişkenine aktarır.
Console.Write(" bir sayı giriniz");
int sayi2 = Convert.ToInt32(Console.ReadLine());
int toplam = sayi + sayi2; //sayı ve sayi2 değişkenlerini toplar ve tanımlanan toplam değişkenine aktarır
Console.WriteLine("sayıların toplamı {0}", toplam);
--------------------------------