using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            Cat cat4 = new Cat("Anton", new DateTime(2015, 02, 04));
            int corm = Int32.Parse(cat4.GetStatus());
            corm += Int32.Parse(cat4.GetStatus());
        }

        public CommandCenter(CatSmartHouse catSmart)
        {



            WaitCommands();
        }
        
            

        
    
       
    }
}
