using System;

class MainClass
{
    public static void Main(string[] args)
    {

        Product Urun1 = new Product();
        Urun1.ProductName = "Ayçiçek Yağı";
        Urun1.ProductSeller = "Olin";
        Urun1.ProductOriginalCost = 100;
        Urun1.ProductDiscountPercentage = 0.15f;


        Product Urun2 = new Product();
        Urun2.ProductName = "Topuklu Ayakkabı";
        Urun2.ProductSeller = "Nine West";
        Urun2.ProductOriginalCost = 200;

        Product Urun3 = new Product();
        Urun3.ProductName = "Kahve Fincanı";
        Urun3.ProductSeller = "Karaca";
        Urun3.ProductOriginalCost = 50;

        Product[] Urunler = new Product[] { Urun1, Urun2, Urun3 };


        Console.WriteLine(Environment.NewLine + "FOR İLE BASIM: " + Environment.NewLine);
        for (int i = 0; i < Urunler.Length; i++)
        {
            Console.WriteLine("Ürün Adı: " + Urunler[i].ProductName + Environment.NewLine + "Satıcısı: " + Urunler[i].ProductSeller + Environment.NewLine + "Ürün Fiyatı: " + IndirimHesapla(Urunler[i]));
            Console.WriteLine("---------");

        }


        Console.WriteLine(Environment.NewLine + "FOREACH İLE BASIM: " + Environment.NewLine);
        foreach (Product urun in Urunler)
        {
            Console.WriteLine("Ürün Adı: " + urun.ProductName + Environment.NewLine + "Satıcısı: " + urun.ProductSeller + Environment.NewLine + "Ürün Fiyatı: " + IndirimHesapla(urun));
            Console.WriteLine(".........");
        }



        Console.WriteLine(Environment.NewLine + "WHILE İLE BASIM: " + Environment.NewLine);
        int counter = 0;
        while (counter < Urunler.Length)
        {
            Console.WriteLine("Ürün Adı: " + Urunler[counter].ProductName + Environment.NewLine + "Satıcısı: " + Urunler[counter].ProductSeller + Environment.NewLine + "Ürün Fiyatı: " + IndirimHesapla(Urunler[counter]));
            Console.WriteLine(",,,,,,,,");
            counter++;
        }
    }

    static float IndirimHesapla(Product x)
    {

        if (x.ProductDiscountPercentage == 0)
            return x.ProductOriginalCost;
        else
            return x.ProductDiscountedCost = x.ProductOriginalCost - (x.ProductOriginalCost * x.ProductDiscountPercentage);


    }



}

class Product
{ //Product objesi

    public string ProductName;
    public string ProductSeller;
    public float ProductOriginalCost;
    public float ProductDiscountPercentage = 0;
    public float ProductDiscountedCost = 0;

}