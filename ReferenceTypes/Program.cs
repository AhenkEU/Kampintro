using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //       //int,decimal,float,boolean value types(deger tip)
            //       //değer tiplerle alakalı her şey sadece stackte oluşur.
            //    int sayi1 = 10;
            //    int sayi2 = 20;

            //    sayi1 = sayi2; // sadece o anki değeri aktardık, referans değil.
            //    sayi2 = 100;
            //    Console.WriteLine("Sayı1=" + sayi1);

            //    //array,class,interfaceler reference typelardır.
            //    //işin içine ref type girerse, heap de olaya dahil olur.
            //    //=new dediğimiz anda stack için heapte adres oluşur.R Eşitlediğimizde artık adresi
            //    //eşitlemiş oluruz diğerine.
            //    int[] sayilar1 = new int[] { 1, 2, 3 };
            //    int[] sayilar2 = new int[] { 10, 20, 30 };

            //    sayilar1 = sayilar2;
            //    sayilar2[0] = 1000;

            //    Console.WriteLine("Sayılar1[0]=" + sayilar1[0]);


            //Başka örnek
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";

            //Burada değer eşitlemesi değil adres eşitlemesi yapılıyor.
            person2 = person1;
            
            person1.FirstName = "Derin";
            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "123456789";
            Employee employee = new Employee();
            employee.FirstName = "Veli";


            //Başka örnek
            Person person3 = customer; //person3 yine customerın adresini tutuyor.
            customer.FirstName = "Ahmet";

            Console.WriteLine(person3.FirstName);
            // Console.WriteLine(person3.CreditCardNumber); bu çıkmayacaktır çünkü person classında kredi kartı nosu yok
            //Fakat customer ondan inheritlendiği için boxing ile bu mümkün.

            Console.WriteLine(customer.CreditCardNumber);
            Console.WriteLine(((Customer)person3).CreditCardNumber); //person3e customerboxingi yaptım


            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
        }
    }

    class Person { 
    public int Id { get; set; }
    public string FirstName { get; set; }

    public string LastName { get; set; }
    }

    //base class : Person

    //base class a onu inherit eden sınıfların referansını atayabilirsiniz.
    //customerın da employeenin de adresini tutabiliyor. Inherit edildiği için
    class Customer:Person {  //Customer is a person. Müşteri bir kişidir. Personu inherit etti customer.

    public string CreditCardNumber { get; set; }
    }

    class Employee:Person
    { 
    public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person) {
            Console.WriteLine(person.FirstName);
        }
    
    }
}
