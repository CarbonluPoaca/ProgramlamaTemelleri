
//tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır
//Dont Repeat Your Self - DRY - Clean Code - Best Practice
using Methods;
using Methods12012024;



Product product1 = new Product();
product1.Name = "Elma";
product1.Description = "Amasya Elması";
product1.Price = 18.2;

Product product2 = new Product();
product2.Name = "Karpuz";
product2.Description = "Diyarbakır karpuzu";
product2.Price = 87;

Product[] products = new Product[] { product1, product2 };

foreach (var product in products)
{
    Console.WriteLine(product.Name + ": " + product.Price);
    Console.WriteLine(product.Description);
    Console.WriteLine("--------------");
}

Console.WriteLine("---------------METOTLAR-------------");
SepetMenager sepetMenager = new SepetMenager();

//Bir kod bloğunu 4 farklı sayfada ayrı ayrı yazmak yerine fonksiyon kullanarak kod bloğunu 4 farklı sayfada çağırdık. Bir değişiklik yapmak istediğimizde sayfalarda ayrı ayrı değişiklik yapmak yerine sadece SepetMenager'da değişiklik yapmamız gerekecektir
sepetMenager.Add(product1);
sepetMenager.Add(product2);

//sepetMenager.Add2("Elma","Amasya elması",12); //Farklı bir parametre eklememiz gerektiği zaman farklı sayfalarda çağırdığımız Add2 fonksiyonu patlar çünkü fonksiyonun imzasına uymamış oluruz bu yüzden Add fonksiyonunda parametre olarak class ekliyoruz bu duruma Encapsulation denir
