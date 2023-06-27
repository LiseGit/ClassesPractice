using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    public class Square : Figure
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }

        public override Double GetSquare()
        {
            return side * side;
        }
    }
}
