using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace memes1125
{
    class CommandCenter
    {
        
        public void WaitCommands()
        {
            string command = null;
            string exit =null ;
            if( command == exit)
            {
                CatSmartHouse SmartHouse = new CatSmartHouse();

                Console.SetCursorPosition(0, 3 + 1);
                command = Console.ReadLine();
                string[] array = command.Split();
                if(array[0] == "exit")
                {
                    
                   SmartHouse.FoodResource += Int32.Parse(array[2]);
                   Console.Write( array[1]);
                }
            }
            command = Console.ReadLine();
            

            switch (command)
            {
                case "Clear":
                    Console.SetCursorPosition(5, 10);
                    Console.Clear();
                    break;
                case "help":
                    Console.WriteLine("Clear", "help", "ChangeHungryLimit");
                    break;
                case "ChangeHungryLimit":

                    HungryLimit();
                    break;
            }
            
            

        }
       
        private void HungryLimit()
        {
            object sender = null;
            var cat = (Cat)sender;
            if ((cat.HungryStatus > 10) || (cat.HungryStatus > 40) ||
                (cat.HungryStatus > 70) || (cat.HungryStatus > 90))
            {
                cat.HungryStatus++;
                Console.WriteLine("Кошка покормлена");

                return;
            }


        }
        public List<Cat> cats = new List<Cat>();
        public void AddCat(Cat cat)
        {
            cats.Add(cat);

        }
        public CommandCenter(CatSmartHouse catSmartH)
        {
            
            


            WaitCommands();
        }
        
            

        
    
       
    }
}
