using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    public class Circle : Figure
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override Double GetSquare()
        {
            return Math.PI * radius * radius;
        }
    }
}
