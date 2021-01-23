using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //Ben mylistimde T ile çalışıcam.
    {
        T[] items; //methodun dışında yazdığım değişken, classın içindeki her operasyondan ulaşılabilir.
        // Burada bir dizi newlemek zorundayım, çünkü T için bellekte yer açmadım. Yoksa null ref hatası gelir.

        //constructor.Classın ismiyle aynıdır.Classı newlediğin yerde bu otomatik çalışacak.
        public MyList()
        {
            items = new T[0];

        }
        public void Add(T item) 
            // programcı newlerken ne verirse o olsun. Ben sana T olarak ne verirsem istediğim elemanın da türü odur.
        {
            T[] tempArray = items; //geçici diziye itemsın refini koy.
            items = new T[items.Length+1]; // eklediğim her elemanda arrayin sayısı 1 artsın
            //Newlediğim anda yeni ref numarası alır. Eski tutulanlar uçar.Uçmasın diye tempe emanet.

            for (int i = 0; i < tempArray.Length; i++) //tempArraye verdiğim emanet elemanları geri alıyorum burada
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }

        public int Length {
            get { return items.Length; }
        }
        public T[] Items {

            get { return items; }
       
        }
    
    }
}
