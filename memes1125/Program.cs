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

            Cat cat1 = new Cat("Marisia", new DateTime(2000,03,08));
            Cat cat = new Cat("Marusia",new DateTime(2001,03,05));
            cat.Makenois();
            cat.HungryStatus = 150;

            cat.HungryStatusChanged += delegatt;
            cat1.HungryStatusChanged += delegatt ;
          
            Console.WriteLine($"Кошке по имени{cat.Name} уже {cat.GatAge()} лет");

            


            Console.ReadLine();
            
        }
        private static void delegatt(object sender, EventArgs e)
        {

            Random rnd = new Random();
            Cat cat = (Cat)sender;
            if (cat.HungryStatus < 20 && rnd.Next(0, 10) < 5)
                cat.Feed();
            else
                cat.GetStatus();
        }
      
    }
}
