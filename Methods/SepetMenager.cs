using Methods12012024;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Methods
{
    internal class SepetMenager
    {
        public void Add(Product product) //Product tipinde product isimli bir parametre ekledik 
        {
            Console.WriteLine(product.Name + ": Sepete eklendi");
        }

        public void Add2(string productName, string productDescription, int productPrice ) 
        {
            Console.WriteLine(productName + ": Sepete eklendi");
        }
    }
}
