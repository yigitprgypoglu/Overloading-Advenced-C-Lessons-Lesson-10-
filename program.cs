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
            //Overlodading
            Console.WriteLine(topla(1,4,5));//Overloading aynı işi yapan ama farklı veri girişlerine ihtiyaç duyan metotları daha temiz yönetmek için kullanılır.
            /*Bir metodun "overload" olması için şu kurallardan en az biri geçerli olmalıdır:

            Parametre türleri farklı olmalı: (Örneğin biri int alırken diğeri string almalı).

            Parametre sayısı farklı olmalı: (Örneğin biri 2 parametre alırken diğeri 3 parametre almalı).
            */
            Console.ReadLine(); 
            return 0;
        }

        static int topla(int a, int b) 
        {
            return a + b;
        }

        static int topla(int a,int b,int c) 
        {
            return a + b + c;
        }
    }
}
