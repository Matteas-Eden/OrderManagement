using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class Square : Shape
    {

        // Can be made constant private
        public int SquarePrice = 1;

        public Square(int redSquares, int blueSquares, int yellowSquares)
        {
            Name = "Square";
            base.Price = SquarePrice;
            AdditionalCharge = 1;
            base.RedShapes = redSquares;
            base.BlueShapes = blueSquares;
            base.YellowShapes = yellowSquares;
        }
        
    }
}
