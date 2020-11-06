using System;
using System.Collections.Generic;
using System.Text;

namespace memes1125
{
    class CatSmartHouse
    {
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
                Console.WriteLine($"Покормлена кошка: {cat.Name}\nОстаток еды в вольере: {FoodResource}");
            }
        }
    }
}
