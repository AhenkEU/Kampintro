using System;
using System.Collections.Generic;
using System.Text;

namespace metodlar
{
    // naming convention - isimlendirme kuralı
    //syntax
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            /*Büyük ürün tip, küçük ürün aşağıda 
            kullanırken kullanacğım isimlendirme*/

            Console.WriteLine("Tebrikler.Sepete eklendi : " + urun.Adi);
            
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}
