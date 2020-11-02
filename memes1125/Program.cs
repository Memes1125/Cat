using System;
using System.Net.Http.Headers;

namespace memes1125
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Name = "Marusia";
            cat.MakeNoise();
            




            cat.GatAge = 30;
            string name = cat.Name;
            
            Console.WriteLine($"Кошке по имени{cat.Name} уже {cat.GatAge} лет");
            

            
        }
    }
}
