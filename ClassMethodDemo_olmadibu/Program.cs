using System;
using System.Collections;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            

           


            int count = 0;
            
            Musteri mus1  = new Musteri();
            mus1.Musteri_Ad = "Osman";
            mus1.Musteri_id = 123;

            Musteri mus2 = new Musteri();
            mus2.Musteri_Ad = "Ayla";
            mus2.Musteri_id = 234;

            Musteri[] MusteriDizi = new Musteri { mus1, mus2 };

            foreach (Musteri mus in MusteriDizi)
            Console.WriteLine(mus.Musteri_id + mus.Musteri_Ad);
            
            Console.WriteLine("Sona geldi.");


        }
    }
}
