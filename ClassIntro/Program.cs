using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "engin demirog";
            kurs1.IzlenmeOrani = 80;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "python";
            kurs2.Egitmen = "berkay bilgi";
            kurs2.IzlenmeOrani = 60;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "java";
            kurs3.Egitmen = "kerem varış";
            kurs3.IzlenmeOrani = 70;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "c++";
            kurs4.Egitmen = "murat kurtboğan";
            kurs4.IzlenmeOrani = 100;


            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3,kurs4 };

            foreach (var kurs  in kurslar)
            {
                //Console.WriteLine(kurs.Egitmen);
                //Console.WriteLine(kurs.IzlenmeOrani);
                //Console.WriteLine(kurs.KursAdi);

                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);



            }
        }


    }

    class Kurs
    {
        public string  KursAdi { get; set; }
        public  string Egitmen  { get; set; }

        public int   IzlenmeOrani { get; set; }
    }
}
