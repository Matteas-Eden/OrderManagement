using System;
using System.Linq;

namespace Order.Management
{
    internal abstract class Report
    {
        protected Report(Order myOrder, int tableWidth)
        {
            MyOrder = myOrder;
            TableWidth = tableWidth;
        }

        protected Order MyOrder { get; }
        private int TableWidth { get; }

        public abstract void GenerateReport();

        protected virtual void GenerateTable()
        {
            PrintLine();
            PrintRow("        ", "   Red   ", "  Blue  ", " Yellow ");
            PrintLine();
            // Would it be going too far to put this into its own overridable method?
            foreach (var shape in MyOrder.OrderedBlocks)
                PrintRow(shape.Name, shape.RedShapes.ToString(),
                    shape.BlueShapes.ToString(), shape.YellowShapes.ToString());
            PrintLine();
        }

        protected void PrintLine()
        {
            Console.WriteLine(new string('-', TableWidth));
        }

        protected void PrintRow(params string[] columns)
        {
            var width = (TableWidth - columns.Length) / columns.Length;
            var row = columns.Aggregate("|", (current, column) => current + AlignCentre(column, width) + "|");

            Console.WriteLine(row);
        }

        private string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
                return new string(' ', width);
            return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
        }
    }
}