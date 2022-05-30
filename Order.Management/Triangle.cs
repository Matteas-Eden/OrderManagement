namespace Order.Management
{
    internal class Triangle : Shape
    {
        private const int TrianglePrice = 2;

        public Triangle(int redTriangles, int blueTriangles, int yellowTriangles)
        {
            Name = "Triangle";
            Price = TrianglePrice;
            RedShapes = redTriangles;
            BlueShapes = blueTriangles;
            YellowShapes = yellowTriangles;
        }
    }
}