using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class PaintingReport : Report
    {
        public PaintingReport(Order myOrder, int tableWidth) : base(myOrder, tableWidth)
        {
        }

        public override void GenerateReport()
        {
            Console.WriteLine("\nYour painting report has been generated: ");
            Console.WriteLine(base.ToString());
            GenerateTable();
        }
        
    }
}
