using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class Triangle : Shape
    {
        // Can be made constant private
        private const int TrianglePrice = 2;
        public Triangle(int redTriangles, int blueTriangles, int yellowTriangles)
        {
            Name = "Triangle";
            base.Price = TrianglePrice;
            base.RedShapes = redTriangles;
            base.BlueShapes = blueTriangles;
            base.YellowShapes = yellowTriangles;
        }

    }
}
