using System;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.IO;

namespace memes1125
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Marusia",new DateTime(2001,03,05));
            cat.Makenois();
            cat.HungryStatus = 150;
            Console.WriteLine($"Кошке по имени{cat.Name} уже {cat.GatAge()} лет");
            

            
        }
    }
}
