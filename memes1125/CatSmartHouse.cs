using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Text;

namespace memes1125
{
    class CatSmartHouse
    {
        public int CatsCount {get; set;}



        public static void PrintStatus()
        {
            Cat cat3 = new Cat("Ne_Ne_Marusia", new DateTime(2011, 02, 30));

            int leftPosition = Console.CursorLeft;
            int topPosition = Console.CursorTop;
            for (int i =0; i < 3; i++)
            {
                string color = null;
                string message = null;
                
                message =  cat3.GetStatus();
                color = color.Substring(0, 2);
                color.Replace(" ","");
                char[] characters = color.ToCharArray();
                Console.SetCursorPosition(0, i);

                Console.Write(message);
                color.Substring(2);
                color.PadRight(50);
                Console.ForegroundColor = 0;
                Console.BackgroundColor = 0;

                

            }

            Console.SetCursorPosition(0, 3);
            Console.Write($"{foodResource}");

            Console.SetCursorPosition(leftPosition, topPosition);
        }
            

           
        public static int FoodResource 
        {
            get
            {
                return foodResource;
            }
            set
            {
                
            }

        }
        List<Cat> cats = new List<Cat>();

        

        public static int foodResource
        {
            get;
            set;
        }
        
        public void AddCat(Cat cat)
        {
            cats.Add(cat);
            
        }
        
       private static void smart(object sender, EventArgs e)
        {
            var cat = (Cat)sender;
            if (cat.HungryStatus <= 20 && FoodResource > 0)
            {
                byte needFood = (byte)(100 - cat.HungryStatus);
                if (FoodResource > needFood)
                    FoodResource -= needFood;
                else
                {
                    needFood = (byte)FoodResource;
                    FoodResource = 0;
                }
                cat.Feed(needFood);
                PrintStatus();
            }
        }
    }
}
