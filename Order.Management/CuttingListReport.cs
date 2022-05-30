using System;

namespace Order.Management
{
    /*
     * I'm not convinced the inheritance makes sense here. Should the report
     * really extend off of the Order? Would it not make more sense that an Order
     * object is passed to a method which generates the report?
     */
    internal class CuttingListReport : Report
    {
        public CuttingListReport(Order myOrder, int tableWidth) : base(myOrder, tableWidth)
        {
        }

        public override void GenerateReport()
        {
            Console.WriteLine("\nYour cutting list has been generated: ");
            Console.WriteLine(MyOrder.ToString());
            GenerateTable();
        }

        protected override void GenerateTable()
        {
            PrintLine();
            PrintRow("        ", "   Qty   ");
            PrintLine();
            foreach (var shape in MyOrder.OrderedBlocks) PrintRow(shape.Name, shape.TotalQuantityOfShape().ToString());
            PrintLine();
        }
    }
}