using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class Triangle : Shape
    {
        // Can be made constant private
        public int TrianglePrice = 2;
        public Triangle(int redTriangles, int blueTriangles, int yellowTriangles)
        {
            Name = "Triangle";
            base.Price = TrianglePrice;
            AdditionalCharge = 1;
            base.RedShapes = redTriangles;
            base.BlueShapes = blueTriangles;
            base.YellowShapes = yellowTriangles;
        }

        public override int Total()
        {
            return RedTrianglesTotal() + BlueTrianglesTotal() + YellowTrianglesTotal();
        }

        public int RedTrianglesTotal()
        {
            return (base.RedShapes * Price);
        }
        public int BlueTrianglesTotal()
        {
            return (base.BlueShapes * Price);
        }
        public int YellowTrianglesTotal()
        {
            return (base.YellowShapes * Price);
        }
    
}
}
