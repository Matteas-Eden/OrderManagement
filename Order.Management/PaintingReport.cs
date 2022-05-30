using System;

namespace Order.Management
{
    internal class PaintingReport : Report
    {
        public PaintingReport(Order myOrder, int tableWidth) : base(myOrder, tableWidth)
        {
        }

        public override void GenerateReport()
        {
            Console.WriteLine("\nYour painting report has been generated: ");
            Console.WriteLine(MyOrder.ToString());
            GenerateTable();
        }
    }
}