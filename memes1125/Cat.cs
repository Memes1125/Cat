using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace memes1125
{
    class Cat
    {

        byte _hungryStatus;
        public Cat(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday; 
            Task.Run(LifeCircle);
        }
        public string Name { get; set; }

        public void Makenois()
        {
            Console.WriteLine($"{Name} мяукает");
        }
        public DateTime Birthday { get; set; }
        public int GatAge()
        {
            return (DateTime.Today - Birthday).Days / 365;
        }
        public byte HungryStatus
        {
            get { return _hungryStatus; }
            set
            {
                if (value < 0)
                {
                    _hungryStatus = 0;
                }
                else if (value > 100)
                {
                    _hungryStatus = 100;
                }
                else
                    _hungryStatus = value;
            }
        }
        public void GetStatus()
        {
            Console.WriteLine(Name);
            Console.WriteLine($"Возраст {GatAge()}");
            if(HungryStatus <= 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Кошка умерает от голода ");
            }
            else if (HungryStatus > 10 && HungryStatus <= 40)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Кошка очень голодна");
            }
            else if(HungryStatus > 40 && HungryStatus <= 70)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Кошка хочет кушать ");
            }
            else if(HungryStatus > 70 && HungryStatus <= 90)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Кошка не против перекусить ");
            }
            else if (HungryStatus > 90)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Кошка недавно поела ");
            }
            Console.ResetColor();
        }
      
      async Task LifeCircle()
        {

            await Task.Delay(10000);
            HungryStatus -= 10;
            GetStatus();
            Task.Run(LifeCircle);
            if (HungryStatus == 0)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Кошки нет в живых");
            }
            else
                await LifeCircle();
            
        }



    }
}
