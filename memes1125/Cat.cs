using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace memes1125
{
    class Cat
    {

        public string name { get; set; }
        public DateTime Birthday { get; set; }
        public Cat() { string Name = name; DateTime birthday = Birthday; byte _hungryStatus = HungryStatus;}
        public int GatAge;
        private byte _hungryStatus;

        public byte HungryStatus
        {

            get
            {
                return _hungryStatus;
            }
            set
            {
                if(value < 0)
                    _hungryStatus = 0;
                if (value > 100)
                    _hungryStatus = 100;


            }
            
        }

        void GetStatus()
        {
            Console.WriteLine($"{name}");
            Console.WriteLine($"Возраст {GatAge}");
            Console.WriteLine(_hungryStatus);
        }

        public void MakeNoise()
        {
         
            Console.WriteLine($"{name} мяукает ");
        }
        

      
    }
}
