using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class Circle : Shape
    {
        // Can be made constant private
        private const int circlePrice = 3;
        public Circle(int red, int blue, int yellow)
        {
            Name = "Circle";
            base.Price = circlePrice;
            base.RedShapes = red;
            base.BlueShapes = blue;
            base.YellowShapes = yellow;
        }
    }
}
