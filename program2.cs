//program2.cs aslinda program.cs ayni adda bir dosya oldugu icin karismamasi icin adini program2.cs koydum
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_3
{
    internal class Program
    {

        static int Main(string[] args)
        {
            sinif x = new sinif();//asagida olusturdugumuz classin icindeki fonksiyonlardan dolayi egerki icine bisey yazmazsak birinci, egerki string deger girersek yazi ve egerki sayi girersek de sayi kelimesini ekrana yazicaktir
            //method overloading budur ayni isimdeki methodlarin ya girilen degisken sayisinin yada degisken turunun farkli olup kodun hata vermeyip sisteme asiri yuklenme yapilmasidir.
            // okunabilirlik acisindan ve kullanim acisindan isi kolaylastirir.
            Console.ReadLine();
            return 0;
        }

        
    }
    class sinif
    {
        public sinif()
        {
            Console.WriteLine("birinci");        
        }
        public sinif(string yazi)
        {
            Console.WriteLine("yazi");
        }
        public sinif(double sayi)
        {
            Console.WriteLine("sayi");
        }
    }
}

