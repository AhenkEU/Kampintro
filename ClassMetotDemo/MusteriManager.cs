using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        static public void MusteriEkle(Musteri mus) {

            Console.WriteLine("Kayıt Alındı. Aramıza Hoşgeldiniz. " + Environment.NewLine + mus.Ad + " " + mus.Soyad);
        }

        static public void MusteriSil(Musteri mus)
        {
            Console.WriteLine("Kayıt Silindi. " + mus.Ad + " " + mus.Soyad);
        }


       static public void List(Musteri[] musteriler)
        {
            foreach (Musteri mus in musteriler)
            {
                Console.WriteLine("Kodu: " + mus.kod);
                Console.WriteLine("Müşteri Adı: " + mus.Ad + " " + mus.Soyad);
                Console.WriteLine("Cinsiyeti:" + mus.cinsiyet);
                Console.WriteLine("---------------");
            }
        }

       
    }
}
