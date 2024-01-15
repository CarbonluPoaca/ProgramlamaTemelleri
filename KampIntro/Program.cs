//type safety - tip güvenliği
//değişken tanımlama: ["değişken türü" "değişken adı" = "değişken değeri"] 

//sayısal değişkenler:
//int - tam sayı tutar (4 bit)
int a = 1;
//float - ondalıklı sayı tutar (4 bit)
//ondalıklı sayı yazarken sayının sonuna f ya da F getirmelisin!
float b = 2;
float c = 2.1f;
float d = 2.2F;
//double - ondalıklı sayı tutar (8 bit)
double e = 3;
double f = 3.1;
double g = 3.2d;
double h = 3.3D;

//metinsel değişklenler:
//char - tek bir karakter tutar (2 bit)
char i = 'i';
char j = 'j';
//string - metin tutar (sınırsız)
string k = "sdas sdas sdas sdas";

//bool - koşullu yapı tutar
bool l = true;
bool m = false;
bool n = 1<2;

//object - tüm değerleri tutar
object o = 4;
object p = 'p';
object r = "sdas sdas";
object s = 4.1;
object t = 4.1f;
//tüm değişken türleri object türünden türemiştir bu yüzden object türü bütün nesne özelliklerini taşır


Console.WriteLine(a + b);
Console.WriteLine(i + j);
//39. satırdaki kod dizisi konsola 3 yazarken 40. satırdaki kod dizisi "ij" yazacaktır
//Writline metodu sayısal değerleri toplarken metinsel değerleri yan yana yazar





