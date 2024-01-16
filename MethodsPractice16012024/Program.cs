
var result = topla2(1, 2);
Console.WriteLine(result);

Console.WriteLine("-----------");
topla1(2, 3);

Console.WriteLine("-----------");

topla3(2);//number2 ya default parametre eklediğimiz için imzada number2'ya değer vermezsek default olarak number2'ya verdiğimiz değeri(30) girecek

Console.WriteLine("-----------");

int a = 20;
int b = 100;
var result2 = topla4(ref a , b);//ilk paremetre artık bir referans almak istediğinden dolayı a'yı parametreye yollarken a'yı değil a'nın referans numarasını yollamış oluruz dolayısıyla artık number1 ve a aynı referansı tutar yani a, number1'i tutar
Console.WriteLine(result2);
Console.WriteLine(a);//a artık mototun içerisindeki number1 ile aynı referansı tuttuğu için number1 üzerinde yapacağımız bir değişiklik a'yı da etkiler çünkü aynı referansı işaretlerler dolayısıyla number1'in refaransına fonksiyon içersinde 30 dediğimiz için artık a nın da referansı 30 olur
Console.WriteLine(b);//fonksiyon içerisinde b'den bağımsız parametrenin değerini 50 ye eşitlemiş olduk o yüzden b aynı değeri tutmaya devam edeceği için ekrana 30 yazdıracaktır. 


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

static int topla4(ref int number1, int number2)//bir metoda ya da assing'ın('=' operatörü) sağ tarafına bir değişkeni gönderirsek o değişkeni değil o değişkenin stackte tuttuğu değeri göndermiş oluruz ama referans tutmak işlem yapmak istiyorsak ref keyword'ünü kullanırız artık ilk parametre bir değer almaz bir referans alır 
{
    number1 = 30; //aldığın referansı 30'a eşitler
    return number1 + number2;
    number2 = 50;//number2'nin değerini 50 ye eşitler
}

