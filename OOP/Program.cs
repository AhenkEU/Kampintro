using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; // 2 numara mobilyaya karşılık geldi diyelim
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3; //Stokta kaç tane kaldı

            //Aşağıdaki farklı bir tanımlama türü
            Product product2 = new Product { Id=2, CategoryId=5, UnitsInStock=5, ProductName= "Kalem", UnitPrice=35 };

            //PascalCase //camelCase büyük küçük harf olayı
            //instance creation
            //sol taraf stack sağ taraf heap
            //stackte oluşturduk ve heapte oluşturduk
            ProductManager productManager = new ProductManager();

            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);


            //int, double, bool... değer tip bu referans değil
            // diziler, classlar, abstract class, interface.. referans tip
            // ref out
        }
    }
}
