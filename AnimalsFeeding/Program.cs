using System;

namespace AnimalsFeeding
{
    class Program
    {
        static void Main(string[] args)
        {
            var food1 = FoodType.PigFood;
            var food2 = FoodType.CatFood;

            var pig = new Pig();
            var cat = new Cat();

            pig.Age = 5;
            cat.Name = "Tom";

            pig.Feed(3);
            cat.Feed(food1, 3);
            cat.Feed(food2, 2);
            cat.SayHelloToCat();

            Console.WriteLine(pig.Satiety);
            Console.WriteLine(cat.Satiety);
        }
    }
}
