// See https://aka.ms/new-console-template for more information

using Math12012024;




DortIslem dortIslem = new DortIslem();
bool b = true;
while (b == true)
{
    string a = Console.ReadLine();
    dortIslem.kufur(a);
}




Console.WriteLine("--------------------");
dortIslem.toplama(2,3);
Console.WriteLine("----------");
dortIslem.cıkarma(2,5);