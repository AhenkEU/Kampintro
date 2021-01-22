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

            List<string> liste = new List<string>();
            Console.WriteLine(liste.Count);
        }
    }
}
