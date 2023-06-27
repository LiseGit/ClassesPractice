using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsFeeding
{
    public class Cat : Animal
    {
        public string Name { get; set; }

        public void Feed(FoodType foodType, int count)
        {
            if (foodType != FoodType.CatFood)
            {
                Console.WriteLine("Meow, I dont eat this!");

                return;
            }

            base.Feed(count);
        }

        public void SayHelloToCat()
        {
            Console.WriteLine($"Hello, {Name}");
        }
    }
}
