using System;
using System.Collections.Generic;
using System.Text; 

namespace MyDictionary_Learning
{
    class MyDictionary<T_Key, T_Value>
    {   //myDictionary için anahtar, değer, geçici anahtar ve geçici değer tanımlaması yapıyoruz.
        //Böylece stackte tanımlanmış oldular.

        T_Key[] _keys;
        T_Value[] _values;

        T_Key[] _tempKey;
        T_Value[] _tempValue;

        public MyDictionary() 
        {   //constructor classında tanımlarımız için heapten referans alanları açıyoruz.
            _keys = new T_Key[0];
            _values = new T_Value[0];

            _tempKey = new T_Key[0];
            _tempValue = new T_Value[0];

        }

        //Ekleme fonksiyonu aşağıda.
        public void Add(T_Key key, T_Value value )
        {   //Önce anahtar ve değer dizilerimizi geçicilere aktarıp yedekledik.
            _tempKey = _keys;
            _tempValue = _values;

            //Anahtar ve değer dizilerimizi bir arttırarak tekrar oluşturduk. 
            //Yeni referans alanı ile bomboş yeni diziler oluştu. Sadece adı aynı. 
            _keys = new T_Key[_keys.Length + 1];
            _values = new T_Value[_values.Length + 1];

            //Geçici anahtar dizimizin toplam sayısının bir eksiği kadar dönerek
            //yedeklediğimiz key ve anahtar dizilerimizin içeriğini, ana dizilerimize aktarıyoruz.
            //Daha en son gelen elemanı koymadık.
            for (int i = 0; i < _tempKey.Length; i++)
            {
                _keys[i] = _tempKey[i];
                _values[i] = _tempValue[i];
            }

            //En son gelen elemanı, anahtar ve değer dizilerimizin en sonuna ekliyoruz.
            // -1 yapmamızın sebebi, toplam uzunluk örn. 6 olsa bile, sonuncunun 5.sırada eklenmesi
            //Çünkü diziler sıfırıncı elemandan başlarlar.
            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;


        }
        //Ahenk Er tarafından yazıldı.
        public int Count
        {
            //Sayma fonksiyonu. Sadece anahtar dizinin değerini döndürse yeter.
 
            get { return _keys.Length; }

        }
    }
}
