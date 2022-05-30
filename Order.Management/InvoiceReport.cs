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
            Console.WriteLine("\n");
            OrderShapeDetails();
            RedPaintSurcharge();
        }

        private int TotalPriceRedPaintSurcharge()
        {
            var amount = 0;
            
            foreach (var shape in MyOrder.OrderedBlocks)
            {
                amount += shape.AdditionalChargeTotal();
            }

            return amount;
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
            {
                CostingPerItem(shape.Name, shape.TotalQuantityOfShape(), shape.Price, shape.Total());
            }
        }
        
        private void RedPaintSurcharge()
        {
            CostingPerItem("Red Color Surcharge", TotalAmountOfRedShapes(), 
                Globals.ExtraChargeForRed, 
                TotalPriceRedPaintSurcharge());
        }

    }
}
