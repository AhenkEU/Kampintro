using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName="Engin", LastName="Demiroğ", City="Ankara" };

            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara"); // böyle kullanmak istersem classın get içine parametreleri tanımlamam gerekr

            Console.WriteLine(customer2.FirstName);
            
        }

    }

    class Customer {

        //burada iki tane constructor kullandık ki, birbirlerini overload ediyorlar.Yukarıdaki 
        //iki ayrı customer doldurumunu da kullanabilelim diye.
        public Customer()
        {//parametresi olmayan constructora default constructor denir.

        }

        //default constructor.Bloğu yazmasan da arkada çalışır.
        //varsa senin yazdığın, yoksa defaultu.
        public Customer(int id, string firstName, string lastName, string city)
        {
            Console.WriteLine("Yapıcı blok çalıştı.");
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
