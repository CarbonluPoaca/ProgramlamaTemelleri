
var result = topla2(1, 2);
Console.WriteLine(result);
Console.WriteLine("-----------");
topla1(2, 3);
Console.WriteLine("-----------");
topla3(2);//number2 ya default parametre eklediğimiz için imzada number2'ya değer vermezsek default olarak number2'ya 30 değeri vermişiz gibi işlem gerçekleştirecek

static void topla1(int number1, int number2)//void içerideki kod bloğunu fonksiyonu çağırdığın noktada gerçekleştirir
{
    Console.WriteLine(number2 + number1);
}

static int topla2(int number1,  int number2)//fonksiyonlar sadece void ile çağırılmaz int,string gibi değer tipteki fonksiyonlar da yazılabilir
{
    var result = number1 + number2; 
    return result; //değer tipteki bir fonksiyon yazdığımız zaman return komutu ile fonksiyonda bir değer döndürülmesini sağlamalıyız
}

static int topla3(int number1, int number2=30)//number2 ya bir default parametre eklemiş olduk 
{
    var result = (number1 + number2);
    return result;
}