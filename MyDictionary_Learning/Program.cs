using System;
using System.Collections.Generic;

namespace MyDictionary_Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            //Örnek ve karşılaştırma olsun diye Generic kütüphanesindeki 
            //normal Dictionary methodlarını da kullandım.
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("İzmir", "Türkiye");

            //Burada da bizim tanımladığımız çift dizili myDictionary sınıfı var.
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("Ankara", "Türkiye");
            //Ahenk Er tarafından yazıldı.
            Console.WriteLine("Dictionary'e anahtarı İzmir, değeri Türkiye girdisini ekledik");
            Console.WriteLine("MyDictionary'e anahtarı Ankara, değeri Türkiye girdisini ekledik");
            
            Console.WriteLine("Dictionary içindeki eleman sayısı :" + dictionary.Count);
            Console.WriteLine("MyDictionary içindeki eleman sayısı : " + myDictionary.Count);
            
        }
    }
}
