
var result = topla2(1, 2);
Console.WriteLine(result);

Console.WriteLine("-----------");
topla1(2, 3);

Console.WriteLine("-----------");

topla3(2);//number2 ya default parametre eklediğimiz için imzada number2'ya değer vermezsek default olarak number2'ya verdiğimiz değeri(30) girecek

Console.WriteLine("-----------");

int number1 = 20;
int number2 = 100;
var result2 = topla4(ref number1 , number2);
Console.WriteLine(result2);
Console.WriteLine(number1);


static void topla1(int number1, int number2)//void içerideki kod bloğunu fonksiyonu çağırdığın noktada gerçekleştirir
{
    Console.WriteLine(number2 + number1);
}

static int topla2(int number1, int number2)//fonksiyonlar sadece void ile çağırılmaz int,string gibi değer tipteki fonksiyonlar da yazılabilir
{
    var result = number1 + number2;
    return result; //değer tipteki bir fonksiyon yazdığımız zaman return komutu ile fonksiyonda bir değer döndürülmesini sağlamalıyız
}

static int topla3(int number1, int number2 = 30)//number2 ya bir default parametre eklemiş olduk 
{
    var result = (number1 + number2);
    return result;
}
//static int topla3(int number1 = 30, int number2) { } default parametreyi örnekteki gibi ilk ya da ortadaki parametreye ekleyemeyiz. Default parametre her zaman fonksiyonun son parametresi olmak zorundadır

static int topla4(ref int number1, int number2)
{
    number1 = 30;
    return number1 + number2;
}

