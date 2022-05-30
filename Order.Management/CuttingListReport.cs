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
    class CuttingListReport : Order
    {
        // Can be converted to private const
        public int tableWidth = 20;
        public CuttingListReport(string customerName, string customerAddress, string dueDate, List<Shape> shapes)
        {
            base.CustomerName = customerName;
            base.Address = customerAddress;
            base.DueDate = dueDate;
            base.OrderedBlocks = shapes;
        }

        public override void GenerateReport()
        {
            Console.WriteLine("\nYour cutting list has been generated: ");
            Console.WriteLine(base.ToString());
            generateTable();
        }
        // Can be made private; only a single usage
        public void generateTable()
        {
            PrintLine();
            PrintRow("        ", "   Qty   ");
            PrintLine();
            PrintRow("Square",base.OrderedBlocks[0].TotalQuantityOfShape().ToString());
            PrintRow("Triangle", base.OrderedBlocks[1].TotalQuantityOfShape().ToString());
            PrintRow("Circle", base.OrderedBlocks[2].TotalQuantityOfShape().ToString());
            PrintLine();
        }
        // Can also be made private; single usage
        public void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        // Can also be made private; single usage
        // Also, why is columns a string array?
        // Should be integer instead
        public void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        // Can also be made private; single usage
        public string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }


    }
}
