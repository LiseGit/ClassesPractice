using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsFeeding
{
    public class Animal
    {
        public double Satiety { get; set; }

        public void Feed(int count)
        {
            Satiety += count;
            Console.WriteLine("Om-nom-nom");
        }
    }
}
