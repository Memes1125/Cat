using System;
using System.Collections.Generic;
using System.Text;

namespace memes1125
{
    class Cat
    {
         public string name { get; set; }
        public DateTime Birthday { get; set; }
        public Cat() { string Name = name; DateTime birthday = Birthday; }
        public int GatAge;
        
        
       
        public void MakeNoise()
        {
         
            Console.WriteLine($"{name} мяукает ");
        }
        
    }
}
