using System;
using System.Linq;

namespace Order.Management
{
    internal class InvoiceReport : Report
    {
        public InvoiceReport(Order myOrder, int tableWidth) : base(myOrder, tableWidth)
        {
        }

        public override void GenerateReport()
        {
            Console.WriteLine("\nYour invoice report has been generated: ");
            Console.WriteLine(MyOrder.ToString());
            GenerateTable();
            OrderDetails();
        }

        private int TotalAmountOfRedShapes()
        {
            return MyOrder.OrderedBlocks.Sum(shape => shape.RedShapes);
        }

        private void OrderDetails()
        {
            OrderShapeDetails();
            RedPaintSurcharge();
        }

        private int TotalPriceRedPaintSurcharge()
        {
            return MyOrder.OrderedBlocks.Sum(shape => shape.AdditionalChargeTotal());
        }

        private void CostingPerItem(string name, int quantity, int price, int total)
        {
            Console.WriteLine("{0}{1} @ ${2} ppi = ${3}",
                name.PadRight(26),
                quantity,
                price,
                total);
        }

        private void OrderShapeDetails()
        {
            foreach (var shape in MyOrder.OrderedBlocks)
                CostingPerItem(shape.Name, shape.TotalQuantityOfShape(), shape.Price, shape.Total());
        }

        private void RedPaintSurcharge()
        {
            CostingPerItem("Red Color Surcharge", TotalAmountOfRedShapes(),
                Globals.ExtraChargeForRed,
                TotalPriceRedPaintSurcharge());
        }
    }
}