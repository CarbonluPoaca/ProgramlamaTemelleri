
using System;
using System.Linq.Expressions;
using System.Threading.Channels;
//İF-ELSE YAPISI 
//koşula bağlı işlem gerçekleştiren şart bloğu
bool yemekYedinMi = true;
if (yemekYedinMi == true)//paranntez içerisindeki şart sağlanıyorsa 
{
    Console.WriteLine("Afiyet olsun.");
}
else
{
    Console.WriteLine("Yemek ye.");

}

Console.WriteLine("------------------------------------------------------------");

double dolarDun = 7.95;
double dolarBugun = 7.99;
if (dolarDun > dolarBugun)
{
    Console.WriteLine("Dolar değeri arttı.");
}
else if (dolarBugun > dolarDun)
{
    Console.WriteLine("Dolar değeri düştü.");
}
else
{
    Console.WriteLine("Dolar değeri değişmedi.");
}

Console.WriteLine("------------------------------------------------------------");

//TERNARY OPERATÖRÜ
string ternary = yemekYedinMi == false ? "Afiyet olsun" : "Yemek Ye";
Console.WriteLine(ternary);
//if-else ile yukarıda yazdığımız şart bloğunu tek satırda yazmamızı sağlar
//Not: ternary operatörü kullanmak için dönülücek verilerin aynı tipte olması gerekmektedir

Console.WriteLine("------------------------------------------------------------");

//FOR DÖNGÜSÜ
for (int i = 0; i < 10; i++) //"i değerini sıfıra eşitle, i değeri 10'dan küçük olduğu sürece döngüyü çalıştır, i değerini birer birer arrtır"
{
    Console.WriteLine(i);
}

Console.WriteLine("------------------------------------------------------------");

//SWİTCH-CASE YPAISI
//if-else yapısı ile aynı işlevi görür ve kod olarak daha basitleştirilmiş halidir fakar if-else bloğu ile yapabildiğimiz her şeyi switch-case ile yapamazsken switch-case ile yapabildiğimiz her şeyi if-else kullanarak yapabiliriz
for (int k = 0; k < 7; k++)//for döngüsü kullanarak k değeri atıyoruz
{
    switch (k)//k değerini sağlayacak koşulu blok içerisinde arıyor
    {
        case 0: Console.WriteLine("pazartesi"); break;
        case 1: Console.WriteLine("salı"); break;
        case 2: Console.WriteLine("çarşamba"); break;
        case 3: Console.WriteLine("perşembe"); break;   
        case 4: Console.WriteLine("cuma"); break;
        case 5: Console.WriteLine("cumartesi"); break;
        case 6: Console.WriteLine("pazar"); break;
        //yapı içerisinde hangi koşul sağlanıyorsa koşulun içersindeki komutları çalıştırıyor 

        default: Console.WriteLine("böyle bir gün yok"); break;
        //hiçbir koşul sağlanmıyorsa default içerisindeki komutları çalıştırıyor
    }
}

Console.WriteLine("------------------------------------------------------------");

Console.WriteLine("Hava yağmurlu ise 1 değil ise 0 yazınız.");
//"Console.ReadLine()" string tipinde girdi almanı sağlar "Int32.Parse" ise bu girdi integer tipine çevirilmesini sağlar
for (int m = 0; m == 0;)
{
    int YagmurluOlmaDurumu = Int32.Parse(Console.ReadLine());
    switch (YagmurluOlmaDurumu)
    {
        case 1:
            m = 1;
            Console.WriteLine("şemsiyeni al");
            break;
        case 0:
            m = 1;
            Console.WriteLine("şemsiyeni alma");
            break;
        default:
            Console.WriteLine("lütfen belirtilen değerler giriniz");
            break;
    }
}

Console.WriteLine("------------------------------------------------------------");
//ARRAYLER

//string item1 = "apple";
//string item2 = "banana";
//string item3 = "cucumber";

//benzer verileri ayrı ayrı yazmak hem kod kalabalığına hem fazladan uğraşa sebebiyet verir, dolayısıyla bu tarz verileri "array"(dizi) kullanarak tutarız
string[] items = new  [] 
{
    "apple",
  "banana",
  "cucumber"
};

for (int j = 0; j < items.Length; j++) //length, array içindeki veri sayısını belirler
{
    Console.WriteLine(items[j]); //items'ların j. elemanını yaz
}
Console.WriteLine("finish");
//array kullanmasaydık her bir item için ayrı ayrı cw kullanmamız gerekecekti 
 
Console.WriteLine("------------------------------------------------------------");

//FOREACH DÖNGÜSÜ
//arrayler için ayrı döngü yapısı
foreach (var item in items)//"'items' arrayinin içindeki 'item' alliası ile tek tek dön"
{
    Console.WriteLine(item);
}
//"var" değişken tipini (string ya da int) otomatik olarak algılar "var" yerine uygun değişken tipi de yazılabilir

Console.WriteLine("------------------------------------------------------------");

//WHİLE DÖNGÜSÜf
int a = 0;
while (a < 3)//for döngüsüne benzer fakat burada geçici değiken atamıyoruz
{
    Console.WriteLine(a);
    a++;
}



