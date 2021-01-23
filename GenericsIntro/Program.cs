using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Bu ismi koy             //Bellekte bu büyüklükte bir ref olutur, bir adres değeri al demek
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");
            Console.WriteLine(isimler.Length);

            isimler.Add("Kerem");
            Console.WriteLine(isimler.Length);// Bu benim kendi tanımladığım Length

            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }

            //List<string> liste = new List<string>();
            //Console.WriteLine(liste.Count);
        }
    }
}
