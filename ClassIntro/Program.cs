//nesne yönelimli programlama
//classlar birden fazla değer tipe sahip yeni objeler oluşturmanı sağlar

Kurs kurs1 = new Kurs();//kurs tipinde yeni bir "kurs1" classı atadık 
kurs1.DersAdi = "Fizik";
kurs1.Egitmen = "Taha Köse";
kurs1.Izlenme = 900;

Kurs kurs2 = new Kurs();
kurs2.DersAdi = "Türkçe";
kurs2.Egitmen = "Mina Aktaş";
kurs2.Izlenme = 899;

Kurs kurs3 = new Kurs();
kurs3.DersAdi = "Kimya";
kurs3.Egitmen = "Egemen Başaran";
kurs3.Izlenme = 897;

Kurs kurs4 = new Kurs();
kurs4.DersAdi = "Biyoloji";
kurs4.Egitmen = "Nehir Özçiftçi";
kurs4.Izlenme = 896;

//Console.WriteLine(kurs1.DersAdi + " : " + kurs1.Egitmen);
//Console.WriteLine(kurs2.DersAdi + " : " + kurs2.Egitmen);
//Console.WriteLine(kurs3.DersAdi + " : " + kurs3.Egitmen);

Kurs[] kurslar = new Kurs[] //string[] items = new string[] komutunda string tipinde array oluştururken burada Kurs tipinde array oluşturduk
{
    kurs1, kurs2, kurs3, kurs4
};

foreach (var kurs in kurslar)//var burada Kurs tipinde
{
    Console.WriteLine(kurs.DersAdi + " : " + kurs.Egitmen);
} //Yorum satırı içerisindeki kod dizisini optimize ettik


class Kurs
{
    //prop+tab = public .... .... { get; set; }
    public string DersAdi { get; set; }
    public string Egitmen { get; set; }
    public int Izlenme { get; set; }

    //bir eğitim sitesinde herhangi bir kursun farklı değer tiplerinde özellikleri vardır bütün bu özellikler ordaki ... kursunu oluşturur burada bu farklı değer tiplerini tek bir classda tutarak bir "Kurs" objesi oluşturmuş olduk
}
