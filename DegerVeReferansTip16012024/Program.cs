
//int,string,bool gibi değer tipteki değişkenler stackta tutulur ve bunlar bir 'değer' tutar '=' operatörü kullanarak değer tipteki iki farklı değişkeni birbirine eşitlediğimiz(assing ettiğimiz) zaman aslında onların değerlerini eşitlemiş oluruz örneğin:
int x = 2;
int y = 3;
x = y; //-> y'nin değerini x in değerine eşitler ve artık x in ye ile bir bağlantısı kalmaz(x=3'şekilndedir aslında )
y = 4; //-> y'nin değerini 4 e eşitler
Console.WriteLine(x); //ekrana 3 yazar

//ancak array,class,interface gibi yapılar referans tiplidir ve ve stacktaki değişkeni bir referans numarası ile heapte tutar. programcının heape doğrudan erişimi yoktur stackteki değişken referansı ile heapte tuttuğumuz obje üzerinde yetki sahibi oluruz '=' operatörü ile iki referans tipteki değişkeni eşitlediğimiz zaman bu değişkenlerin referans numaralarını eşitlemiş oluruz, örneğin: 
int[] numbers1 = new int[] { 10, 20, 30 };
int[] numbers2 = new int[] { 100, 200, 300 };
numbers1 = numbers2; //-> numbers1'in referans numarasını numbers2'nin referans numarasına eşitler ve artık numbers1 ve numbers2 heapteki aynı referans numarasına ait alanı işaretler 
numbers2[0] = 999; //-> numbers2'nin referans numarasının heaptte tuttuğu alanın 0. elemanını 999'a eşitler
Console.WriteLine(numbers1[0]); //numbers2 ve numbers1'in referans numarası aynı olduğu için artık heapte de aynı alanı tutarlar ve numbers1'in de heapte tuttuğu alanın 0. elemanı 999 olur

//değer tipteki değişkenlerle referans çalışması yapmak istiyorsak 'ref' keywordu kullanırız. 'ref' keywordu değer tipteki değişkenlerin referans tipteki değikenler gibi davranmasını sağlar örneğin:
int a = 5;
int b = a;//burada b'nin n değerini a'ya eşitlemiş olduruz b burada 5 tutarken
ref int c = ref a;//ref keywordu kullanarak değer tipteki c'nin referans numarasını a'ya eşitlemiş oluruz yani c, artık a'yı tutar.
a = 10;
Console.WriteLine(b);//komutu ekrana 5 yazarken
Console.WriteLine(c);//komutu ekrana 10 yazacaktır

