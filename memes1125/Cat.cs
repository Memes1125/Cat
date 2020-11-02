using System;
using System.Collections.Generic;
using System.Text;

namespace memes1125
{
    class Cat
    {
         public string name { get; set; }
        public DateTime Birthday { get; set; }
        public string Name ;
        public DateTime birthday ;
        public int GatAge;
        
       
        public void MakeNoise()
        {
         
            Console.WriteLine($"{Name} мяукает ");
        }
        
    }
}
