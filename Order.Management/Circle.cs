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
        public override int Total()
        {
            return RedCirclesTotal() + BlueCirclesTotal() + YellowCirclesTotal();
        }

        public int RedCirclesTotal()
        {
            return (base.RedShapes * Price);
        }
        public int BlueCirclesTotal()
        {
            return (base.BlueShapes * Price);
        }
        public int YellowCirclesTotal()
        {
            return (base.YellowShapes * Price);
        }
    }
}
