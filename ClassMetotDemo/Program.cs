using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Musteri mus1 = new Musteri();
            mus1.kod = 1;
            mus1.Ad = "Osman";
            mus1.Soyad = "Nadir";
            mus1.cinsiyet = "Erkek";

            Musteri mus2 = new Musteri();
            mus2.kod = 2;
            mus2.Ad = "Ayla";
            mus2.Soyad = "Bilgin";
            mus2.cinsiyet = "Kadın";

            Musteri mus3 = new Musteri();

            mus3.kod = 3;
            mus3.Ad = "Aysun";
            mus3.Soyad = "Öztürk";
            mus3.cinsiyet = "Kadın";


            Musteri[] musteriler = new Musteri[] { mus1, mus2, mus3 };

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("---Ekleme Simulasyonu---" + Environment.NewLine);
            MusteriManager.MusteriEkle(mus1);
            MusteriManager.MusteriEkle(mus2);
            MusteriManager.MusteriEkle(mus3);

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("---Silme Simulasyonu---" + Environment.NewLine);
            MusteriManager.MusteriSil(mus1);
            MusteriManager.MusteriSil(mus2);
            MusteriManager.MusteriSil(mus3);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("---Listeleme Simulasyonu---" + Environment.NewLine);
            MusteriManager.List(musteriler);






        }

        



    }


      }

