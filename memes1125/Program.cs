using System;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;

namespace memes1125
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.name = " Marusia";
            cat.MakeNoise();
            
            




            cat.GatAge = 30;
            string name = cat.name;
            
            Console.WriteLine($"Кошке по имени{cat.name} уже {cat.GatAge} лет");
            

            
        }
    }
}
