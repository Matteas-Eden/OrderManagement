using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class InvoiceReport : Report
    {
        public InvoiceReport(Order myOrder, int tableWidth) : base(myOrder, tableWidth)
        {
        }

        public override void GenerateReport()
        {
            Console.WriteLine("\nYour invoice report has been generated: ");
            Console.WriteLine(base.ToString());
            GenerateTable();
            OrderDetails();
        }

        public void RedPaintSurcharge()
        {
            Console.WriteLine("Red Color Surcharge       " + TotalAmountOfRedShapes() + " @ $" +
                              MyOrder.OrderedBlocks[0].AdditionalCharge + " ppi = $" + TotalPriceRedPaintSurcharge());
        }

        private int TotalAmountOfRedShapes()
        {
            var amountOfRedShapes = 0;
            
            foreach (var shape in MyOrder.OrderedBlocks)
            {
                amountOfRedShapes += shape.RedShapes;
            }

            return amountOfRedShapes;
            
        }

        private void OrderDetails()
        {
            OrderSquareDetails();
            OrderTriangleDetails();
            OrderCircleDetails();
            RedPaintSurcharge();
        }

        public int TotalPriceRedPaintSurcharge()
        {
            return TotalAmountOfRedShapes() * MyOrder.OrderedBlocks[0].AdditionalCharge;
        }
       
        public void OrderSquareDetails()
        {
            Console.WriteLine("\nSquares 		  " + MyOrder.OrderedBlocks[0].TotalQuantityOfShape() + " @ $" +
                              MyOrder.OrderedBlocks[0].Price + " ppi = $" + MyOrder.OrderedBlocks[0].Total());
        }
        public void OrderTriangleDetails()
        {
            Console.WriteLine("Triangles 		  " + MyOrder.OrderedBlocks[1].TotalQuantityOfShape() + " @ $" +
                              MyOrder.OrderedBlocks[1].Price + " ppi = $" + MyOrder.OrderedBlocks[1].Total());
        }
        public void OrderCircleDetails()
        {
            Console.WriteLine("Circles 		  " + MyOrder.OrderedBlocks[2].TotalQuantityOfShape() + " @ $" +
                              MyOrder.OrderedBlocks[2].Price + " ppi = $" + MyOrder.OrderedBlocks[2].Total());
        }
        
    }
}
