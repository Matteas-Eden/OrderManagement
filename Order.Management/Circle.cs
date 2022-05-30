namespace Order.Management
{
    internal class Circle : Shape
    {
        private const int circlePrice = 3;

        public Circle(int red, int blue, int yellow)
        {
            Name = "Circle";
            Price = circlePrice;
            RedShapes = red;
            BlueShapes = blue;
            YellowShapes = yellow;
        }
    }
}