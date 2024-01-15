// See https://aka.ms/new-console-template for more informati
using System.Reflection.Metadata;

Product product1 = new Product();//Product tipinde yeni bir obje oluşturduk
product1.BrandName = "Faber Castel";
product1.ProductName = "sdf9 Uçlu Kalem";
product1.ProductCategory = "Kırtasiye Ürünleri";
product1.ProductDescription = "0.7 uçlu kalem";
product1.Price = 98;
product1.ProductRating = 4.8f;

Product product2 = new Product();
product2.BrandName = "Faber Castel";
product2.ProductName = "jj2 Silgi";
product2.ProductCategory = "Kırtasiye Ürünleri";
product2.ProductDescription = "Beyaz silgi";
product2.Price = 15;
product2.ProductRating = 4.3f;

Product product3 = new Product();
product3.BrandName = "Butterfly";
product3.ProductName = "qxc10 Tenis Raketi";
product3.ProductCategory = "Spor malzemeleri";
product3.ProductDescription = "Başlangıç için uçlu kalem ";
product3.Price = 403;
product3.ProductRating = 4;

Product[] products = new Product[] { product1, product2, product3 };

Console.WriteLine("--------------------FOREACH----------------------");

int foreachSayı = 0;
foreach (var product in products)
{
    Console.WriteLine(product.BrandName + ": " + product.ProductName);
    Console.WriteLine(product.ProductCategory);
    Console.WriteLine(product.ProductDescription);
    Console.WriteLine(product.Price);
    Console.WriteLine(product.ProductRating);
    string bosluk = foreachSayı == products.Length - 1 ? "" : ":::::::::::::::::::::::";//şart bloğu ile son üründen sonra boşluk bırakmıyor
    Console.WriteLine(bosluk);
    foreachSayı++;
}

Console.WriteLine("--------------------FOR--------------------------");

for (int i = 0; i < products.Length; i++)
{
    Console.WriteLine(products[i].BrandName + ": " + products[i].ProductName);
    Console.WriteLine(products[i].ProductCategory);
    Console.WriteLine(products[i].ProductDescription);
    Console.WriteLine(products[i].Price);
    Console.WriteLine(products[i].ProductRating);
    string bosluk = i == products.Length-1 ? "" : ":::::::::::::::::::::::";
    Console.WriteLine(bosluk);
}

Console.WriteLine("---------------------WHİLE-----------------------");

int j = 0;
while (j < products.Length)
{
    Console.WriteLine(products[j].BrandName + ": " + products[j].ProductName);
    Console.WriteLine(products[j].ProductCategory);
    Console.WriteLine(products[j].ProductDescription);
    Console.WriteLine(products[j].Price);
    Console.WriteLine(products[j].ProductRating);
    string bosluk = j == products.Length-1 ? "" : ":::::::::::::::::::::::";
    Console.WriteLine(bosluk);
    j++;
}


class Product//Product tipinde class oluşturduk
{
    public string BrandName { get; set; }
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    public string ProductCategory { get; set; }
    public int Price { get; set; }
    public float ProductRating { get; set; }

}