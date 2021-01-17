using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs(); //yeni bir class değişkeni açmak
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;


            Kurs kurs2 = new Kurs(); //yeni bir class değişkeni açmak
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Ahenk Er";
            kurs2.IzlenmeOrani = 168;

            Kurs kurs3 = new Kurs(); //yeni bir class değişkeni açmak
            kurs3.KursAdi = "Phyton";
            kurs3.Egitmen = "Berkay";
            kurs3.IzlenmeOrani = 88;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            //içinde kurs nesnesi bulunduran bir array tanımladım
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.Egitmen);
            }

            //Console.WriteLine("Hello World!");
        }
    }

    class Kurs  // Kurs objesi
    {    // Aşağıdakiler property, yani özellik
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
