using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Text;

namespace memes1125
{
    class CatSmartHouse
    {

        static object printing = true;



        public int CatsCount {get; set;}

        

        public static void PrintStatus(object sander, EventArgs e)
        {
            lock (printing)
            {
                var cat1 = (Cat)sander;
                int leftPosition = Console.CursorLeft;
                int topPosition = Console.CursorTop;
                for (int i = 0; i < 3; i++)
                {
                    string color = null;
                    string message = null;

                    message =  cat1.GetStatus();
                    color = color.Substring(0, 2);
                    color.Replace(" ", "");
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
        }
            

           
        public  int FoodResource 
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
        
       private  void smart(object sender, EventArgs e)
        {
            var cat = (Cat)sender;
            if (cat.HungryStatus <= 20 && FoodResource > 0)
            {
                sbyte needFood = (sbyte)(100 - cat.HungryStatus);
                if (FoodResource > needFood)
                    FoodResource -= needFood;
                else
                {
                    needFood = (sbyte)FoodResource;
                    FoodResource = 0;
                }
                cat.Feed(needFood);
                PrintStatus(sender,e);
            }
        }
    }
}
