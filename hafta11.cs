class Program
{
/*
erisimBelirleyici niteleyici donusTipi MetotAdi (parametre listesi)
{
//Metot çağrıldığında işletilecek kodlar buraya yazılır.
}
erisimBelirleyicisi: Private(Sadece bu sınıfdan çağırlabilir)
veya Public(Bu sınıf ve diğer sınıflardan çağırılabilir)
niteleyici: static
donusTipi: Metodun çalışması sonucu, kendisini çağırıp kullanana göndereceği verinin tipini belirler.
Bu tip int,string,double vs olabilir. Eğer geri değer dönmeyecekse void olarak tanımlanır.
MetotAdi: metot çağrılırken kullanılacak olan isimdir
parametre listesi: opsiyoneldir; yani kullanılabilir de kullanılmayabilir.
Metoda gönderilecek değerler parametre olarak verilir.
*/
public static void mesajyaz()
{
Console.WriteLine("Nasılsın");
}
static void Main(string[] args)
{
mesajyaz();
mesajyaz();
mesajyaz();
mesajyaz();
}
}
-----------------------------------------------------------------------------------------------------------------
class Program
{
//parametre almayan ve değer döndürmeyen method
public static void hesapla()
{
Console.Write("birinci sayıyı giriniz : ");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.Write("ikinci sayıyı giriniz : ");
int sayi2 = Convert.ToInt32(Console.ReadLine());
int toplam = sayi1 + sayi2;
Console.WriteLine("sayıların toplamı {0}", toplam);
}
static void Main(string[] args)
{
hesapla();
}
}
-----------------------------------------------------------------------------------------------------------------
class Program
{
//parametre alan ve değer döndürmeyen method
public static void hesapla(int sayi1,int sayi2)
{
int toplam = sayi1 + sayi2;
Console.WriteLine("sayıların toplamı {0}", toplam);
}
static void Main(string[] args)
{
hesapla(5,7);
Console.Write("birinci sayıyı giriniz : ");
int s1 = Convert.ToInt32(Console.ReadLine());
Console.Write("ikinci sayıyı giriniz : ");
int s2 = Convert.ToInt32(Console.ReadLine());
hesapla(s1,s2);
}
}
-----------------------------------------------------------------------------------------------------------------
class Program
{
//parametre alan ve değer döndüren method
public static int hesapla(int sayi1,int sayi2)
{
int toplam = sayi1 + sayi2;
return toplam;
}
static void Main(string[] args)
{
int sonuc;
sonuc=hesapla(5,7);
Console.WriteLine("sayıların toplamı {0}", sonuc);
Console.Write("birinci sayıyı giriniz : ");
int s1 = Convert.ToInt32(Console.ReadLine());
Console.Write("ikinci sayıyı giriniz : ");
int s2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("sayıların toplamı {0}", hesapla(s1,s2));
}
}
-----------------------------------------------------------------------------------------------------------------
class Program
{
//gelen parametrelerden büyük olan sayıyı geri döndüren metod
public static int hesapla(int sayi1, int sayi2)
{
if (sayi1 > sayi2) return sayi1;
else return sayi2;
}
static void Main(string[] args)
{
int sonuc=hesapla(15, 7);
Console.WriteLine(sonuc);
Console.WriteLine(hesapla(5, 7));
}
}
-----------------------------------------------------------------------------------------------------------------
class Program
{
//gelen kullanıcı adı ve şifre bilgisinin kontrolünü yapan method
public static bool uyekontrol(string kullanici,string sifre)
{
if (kullanici == "admin" && sifre == "1234")
return true;
else
return false;
}
static void Main(string[] args)
{
Console.Write("Kullanıcı adını giriniz : ");
string kullanici = Console.ReadLine();
Console.Write("şifrenizi giriniz : ");
string sfr = Console.ReadLine();
if (uyekontrol(kullanici, sfr))
Console.WriteLine("giriş başarılı");
else
Console.WriteLine("kullanıcı adı veya şifre hatalı");
}
}
-----------------------------------------------------------------------------------------------------------------
class Program
{
//gelen kullanıcı adı ve şifre bilgisinin kontrolünü yapan method
//kullanıcı adı ve şifre doğru girilene kadar bilgileri istemeye devam eder.
public static bool uyekontrol(string kullanici,string sifre)
{
if (kullanici == "admin" && sifre == "1234")
return true;
else
return false;
}
static void Main(string[] args)
{
string kullanici, sfr;
do
{
Console.Write("Kullanıcı adını giriniz : ");
kullanici = Console.ReadLine();
Console.Write("şifrenizi giriniz : ");
sfr = Console.ReadLine();
}
while (!uyekontrol(kullanici, sfr));
Console.WriteLine("giriş başarılı");
}
}
-----------------------------------------------------------------------------------------------------------------
class Program
{
public static void ekle(ref int b)
{
b++;
}
static void Main(string[] args)
{
int a = 5;
Console.WriteLine("metod öncesi a değişkeni {0}", a);
ekle(ref a);
Console.WriteLine("metod sonrası a değişkeni {0}", a);
}
}
-----------------------------------------------------------------------------------------------------------------
class Program
{
public static void topla(int a,int b,out int c)
{
c = a + b;
}
static void Main(string[] args)
{
int s1 = 5, s2 = 7, snc;
topla(s1, s2, out snc);
Console.WriteLine(snc);
}
}
-----------------------------------------------------------------------------------------------------------------
class Program
{
//aynı isimde farklı parametreler alan metodlar tanımlayabiliriz.
//metodların aşırı yüklenmesi (overloading)
public static int topla(int a,int b)
{
return a + b;
}
public static int topla(int a,int b,int c)
{
return a + b + c;
}
public static int topla(int a, int b, int c,int d)
{
return a + b + c + d;
}
static void Main(string[] args)
{
Console.WriteLine(topla(5, 2));
Console.WriteLine(topla(5, 2, 8));
Console.WriteLine(topla(5, 2, 9, 3));
}
}
-----------------------------------------------------------------------------------------------------------------
class Program
{
/*
params Anahtar Kelimesinin Kullanımı
Bazı durumlarda metot yazılırken metodu çağıranın kaç tane parametre geçireceği önceden belli olmayabilir.
Şu ana kadar öğrenilen bilgilerle bu ihtiyacı karşılayacak bir çözüm yoktur. Ancak, metotlara herhangi bir tipten bir
dizi aktarılması halinde bu sorun kısmen de olsa aşılabilir. Bu iş için, metoda parametre olarak dizi alınması
ve parametrenin önüne params anahtar kelimesinin getilmesi yeterlidir:
*/
public static void parametresayisi(params int[] dizim)
{
Console.WriteLine("toplam {0} parametre gönderildi", dizim.Length);
for (int i = 0; i < dizim.Length; i++)
Console.WriteLine("{0}.parametre = {1}", i, dizim[i]);
}
public static int sayitopla(params int[] dizim)
{
int toplam=0;
for (int i = 0; i < dizim.Length; i++)
toplam+=dizim[i];
return toplam;
}
static void Main(string[] args)
{
parametresayisi(3, 5, 9, 8, 7, 4, 1, 2, 6);
Console.WriteLine(sayitopla(5, 6, 8, 9, 25, 2, 3, 8, 9, 4));
}
------------------------------------------------------------------------------------------------
class Program
{
public static int toplam(params int[] dizim)
{
int toplam=0;
for (int i = 0; i < dizim.Length; i++)
toplam+=dizim[i];
return toplam;
}
public static int enbuyuk(params int[] dizi)
{
int enb = dizi[0];
for (int i = 0; i < dizi.Length; i++)
if (dizi[i] > enb) enb = dizi[i];
return enb;
}
public static int enkucuk(params int[] dizi)
{
int enk = dizi[0];
for (int i = 0; i < dizi.Length; i++)
if (dizi[i] < enk) enk = dizi[i];
return enk;
}
static void Main(string[] args)
{
Console.WriteLine(toplam(5, 6, 8, 9, 25, 2, 3, 8, 9, 4));
Console.WriteLine(enbuyuk(5, 6, 8, 9, 25, 2, 3, 8, 9, 4));
Console.WriteLine(enkucuk(5, 6, 8, 9, 25, 2, 3, 8, 9, 4));
}
}