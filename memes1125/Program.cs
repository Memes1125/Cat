using System;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace memes1125
{
    class Program
    {
        static void Main(string[] args)
        {

            Cat cat1 = new Cat("Ne_Marusia", new DateTime(2000,03,08));
            Cat cat = new Cat("Marusia",new DateTime(2001,03,05));
            cat.Makenois();
            cat.HungryStatus = 150;




            CatSmartHouse catSmartH = new CatSmartHouse();
            catSmartH.AddCat(cat1);
            catSmartH.AddCat(cat);



            Console.WriteLine($"Кошке по имени{cat.Name} уже {cat.GatAge()} лет");



            Console.SetCursorPosition(0, 3 + 1);
            Console.ReadLine();
            
        }
       
       
        
    }
}
