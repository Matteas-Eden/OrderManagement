using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class Square : Shape
    {

        // Can be made constant private
        public int SquarePrice = 1;

        public Square(int numberOfRedSquares, int numberOfBlueSquares, int numberOfYellowSquares)
        {
            Name = "Square";
            base.Price = SquarePrice;
            AdditionalCharge = 1;
            base.NumberOfRedShape = numberOfRedSquares;
            base.NumberOfBlueShape = numberOfBlueSquares;
            base.NumberOfYellowShape = numberOfYellowSquares;
        }

        // This same implementation is in every child of Shape
        // Surely bring this up a level?
        public override int Total()
        {
            return RedSquaresTotal() + BlueSquaresTotal() + YellowSquaresTotal();
        }

        /*
         * All of the below can be made private
         * Each of them have only a single usage, which is in
         * this class.
         */
        public int RedSquaresTotal()
        {
            return (base.NumberOfRedShape * Price);
        }
        public int BlueSquaresTotal()
        {
            return (base.NumberOfBlueShape * Price);
        }
        public int YellowSquaresTotal()
        {
            return (base.NumberOfYellowShape * Price);
        }
    }
}
