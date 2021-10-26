using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // type safety
            string kategori = "kategoriler";
            // do not repeat yourself

            Console.WriteLine(kategori);
            bool giris = true;

            int sayi = 1234567891;
            if (giris==true)
            {
                Console.WriteLine("kullanici gridi");

            }
            else
            {
                Console.WriteLine("giriş yapmadı");
                    
            }

            //array dizi
            string[] kurslar = new string[] { "yazılım kampı ", "merhaba dunya", "hibüşranur", "dinamik ","statik" };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);


            }
            Console.WriteLine("sayfa sonu ********");

            foreach (string  kurs  in kurslar)// dizileri kolay gezmek için kullanırız.
            {
                Console.WriteLine(kurs);

                  
            }

            Console.WriteLine("****sayfa sonuu****");

        }
    }
}
