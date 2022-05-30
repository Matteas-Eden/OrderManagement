using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    /*
     * I'm not convinced the inheritance makes sense here. Should the report
     * really extend off of the Order? Would it not make more sense that an Order
     * object is passed to a method which generates the report?
     */
    class CuttingListReport : Report
    {
        public CuttingListReport(Order myOrder, int tableWidth) : base(myOrder, tableWidth)
        {
        }

        public override void GenerateReport()
        {
            Console.WriteLine("\nYour cutting list has been generated: ");
            Console.WriteLine(base.ToString());
            GenerateTable();
        }
        
        protected override void GenerateTable()
        {
            PrintLine();
            PrintRow("        ", "   Qty   ");
            PrintLine();
            PrintRow("Square",MyOrder.OrderedBlocks[0].TotalQuantityOfShape().ToString());
            PrintRow("Triangle", MyOrder.OrderedBlocks[1].TotalQuantityOfShape().ToString());
            PrintRow("Circle", MyOrder.OrderedBlocks[2].TotalQuantityOfShape().ToString());
            PrintLine();
        }

    }
}
