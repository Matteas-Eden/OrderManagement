namespace Order.Management
{
    internal class Square : Shape
    {
        private const int SquarePrice = 1;

        public Square(int redSquares, int blueSquares, int yellowSquares)
        {
            Name = "Square";
            Price = SquarePrice;
            RedShapes = redSquares;
            BlueShapes = blueSquares;
            YellowShapes = yellowSquares;
        }
    }
}