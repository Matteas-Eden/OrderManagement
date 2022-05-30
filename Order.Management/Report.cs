using System;

namespace Order.Management
{
    abstract class Report
    {
        protected Order MyOrder { get; }
        protected int TableWidth { get; }

        protected Report(Order myOrder, int tableWidth)
        {
            MyOrder = myOrder;
            TableWidth = tableWidth;
        }

        public abstract void GenerateReport();

        protected virtual void GenerateTable()
        {
            PrintLine();
            PrintRow("        ", "   Red   ", "  Blue  ", " Yellow ");
            PrintLine();
            PrintRow("Square", MyOrder.OrderedBlocks[0].RedShapes.ToString(),
                MyOrder.OrderedBlocks[0].BlueShapes.ToString(),
                MyOrder.OrderedBlocks[0].YellowShapes.ToString());
            PrintRow("Triangle", MyOrder.OrderedBlocks[1].RedShapes.ToString(),
                MyOrder.OrderedBlocks[1].BlueShapes.ToString(),
                MyOrder.OrderedBlocks[1].YellowShapes.ToString());
            PrintRow("Circle", MyOrder.OrderedBlocks[2].RedShapes.ToString(),
                MyOrder.OrderedBlocks[2].BlueShapes.ToString(),
                MyOrder.OrderedBlocks[2].YellowShapes.ToString());
            PrintLine();
        }
        
        protected void PrintLine()
        {
            Console.WriteLine(new string('-', TableWidth));
        }

        protected void PrintRow(params string[] columns)
        {
            int width = (TableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        protected string AlignCentre(string text, int width)
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