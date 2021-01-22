using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Product
    {
        public int Id { get; set; } // Ürün kodu
        
        public int CategoryId { get; set; } // Kategori kodu

        public string ProductName { get; set; } //Ürün adı

        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; } //Stok adedi
    }
}
