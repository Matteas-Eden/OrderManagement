namespace Order.Management
{
    public abstract class Shape
    {
        public string Name { get; protected set; }
        public int Price { get; protected set; }
        public int RedShapes { get; protected set; }
        public int BlueShapes { get; protected set; }
        public int YellowShapes { get; protected set; }

        public int TotalQuantityOfShape()
        {
            return RedShapes + BlueShapes + YellowShapes;
        }

        public int AdditionalChargeTotal()
        {
            return RedShapes * Globals.ExtraChargeForRed;
        }

        public int Total()
        {
            return TotalQuantityOfShape() * Price;
        }
    }
}