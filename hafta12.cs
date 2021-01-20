        string ad = "serkan", soyad = "tan";
            Console.Write(ad +" "+ soyad);

-----------------------------------------------------------------------------------------------------

  string isim;
            Console.Write("isminizi giriniz : ");
            isim = Console.ReadLine();
            Console.WriteLine("{0} ismi {1} karakterden oluşuyor",isim,isim.Length);

-----------------------------------------------------------------------------------------------------

            string isim;
            Console.Write("isminizi giriniz : ");
            isim = Console.ReadLine();
            for (int i = 0; i < isim.Length; i++)
                Console.WriteLine(isim[i]);

-----------------------------------------------------------------------------------------------------

//Örnek: Merhaba  yazısının karakterlerini birer satır atlayarak ekrana yazın. 
            string isim;
            Console.Write("isminizi giriniz : ");
            isim = Console.ReadLine();
            for (int i = 0; i < isim.Length; i++)
                Console.Write(isim[i]+" ");

-----------------------------------------------------------------------------------------------------

//Örnek:Klavyeden okuna metni tersinden yazan kodu yazın
            string isim,ters="";
            Console.Write("isminizi giriniz : ");
            isim = Console.ReadLine();

            for (int i = isim.Length - 1; i >= 0; i--)
                ters += isim[i];
            Console.Write("isminizin ters hali : ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(ters);
            Console.ResetColor();

-----------------------------------------------------------------------------------------------------

//harfin ascii karşılığı
            char kr = 'A';
            int ascii = (int)kr;
            Console.WriteLine(ascii);

            kr = (char)ascii;
            Console.WriteLine(kr);

-----------------------------------------------------------------------------------------------------

            string isim;
            Console.Write("isminizi giriniz : ");
            isim = Console.ReadLine();
            Console.Write("isminizin sayısal hali : ");

            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = isim.Length - 1; i >= 0; i--)
                Console.Write("{0}-",(int)isim[i]);
            Console.Write("\b");
            Console.ResetColor();

-----------------------------------------------------------------------------------------------------

//A'dan Z'ye ve a'dan z'ye harfler

            for (int i = (int)'A'; i <= (int)'Z'; i++) Console.Write((char)i);
            Console.WriteLine();
            for (int i = (int)'a'; i <= (int)'z'; i++) Console.Write((char)i);

-----------------------------------------------------------------------------------------------------

//ascii karakterler

  for (int i = 1; i <= 255; i++) Console.Write("{0} - ",(char)i);

-----------------------------------------------------------------------------------------------------

//girilen cümleyi nokta,virgül ve boşluk karakterlerinden parçalara ayırıp her bir parçayı bir dizi elemanı olarak atar.
            Console.Write("bir cümle giriniz : ");
            string cumle = Console.ReadLine();
            string[] kelime = cumle.Split(' ','.',',');
            for (int i = 0; i < kelime.Length; i++)
                Console.WriteLine(kelime[i]);

-----------------------------------------------------------------------------------------------------

//tolower küçük harfe, toupper büyük harfe çevirir
            Console.Write("bir cümle giriniz : ");
            string cumle = Console.ReadLine();
            Console.WriteLine(cumle.ToLower());
            Console.WriteLine(cumle.ToUpper());

-----------------------------------------------------------------------------------------------------

//Replace metin içindeki bir yazıyı başka bir yazı ile değiştir.
            string metin = "Ali eve gel";
            Console.WriteLine(metin);
            metin = metin.Replace("eve", "okula");
            Console.WriteLine(metin);

-----------------------------------------------------------------------------------------------------

//Insert, metnin belirtilen hanesine başka bir metine ekler.
            string metin = "Ali eve gel";
            Console.WriteLine(metin);
            metin = metin.Insert(4, "önce ");
            Console.WriteLine(metin);

-----------------------------------------------------------------------------------------------------

//Remove, belirtilen noktadan itibaren belirtilen sayıda karakteri siler. 
            string metin = "Ali eve gel";
            Console.WriteLine(metin);
            metin = metin.Remove(4, 4);
            Console.WriteLine(metin);

-----------------------------------------------------------------------------------------------------

//    Join, diziyi metne dönüştürür. 
            string[] metin = new string[] { "Ali", "eve", "gel"};
            string cumle;
            cumle = string.Join(' ', metin);
            Console.WriteLine(cumle);

-----------------------------------------------------------------------------------------------------

//    IndexOf, kelimenin ilk bulunduğu hanenin numarasını verir. 
         // metin içinde yoksa -1 sonucu döner
            String metin ="gel Ali gel, gel de bak";
            Console.WriteLine(metin.LastIndexOf("ali")); //-1 yazar çünkü ali != Ali
            Console.WriteLine(metin.LastIndexOf("Ali")); // konum olarak 4 yazar

-----------------------------------------------------------------------------------------------------

//    Substring, metin (başlangıç ve uzunluğu belli olmalı)  bir bölümünü verir.  
            string metin = "Ali eve gel";
            Console.WriteLine(metin.Substring(4, 3)); //eve
            Console.WriteLine(metin.Substring(4)); //eve gel

-----------------------------------------------------------------------------------------------------

//    Concat, birden fazla metni birbirine ekler.  
            string metin1 = "Ali";
            string metin2 = "eve";
            string metin3 = "gel";
            Console.WriteLine(String.Concat(metin1, metin2, metin3));