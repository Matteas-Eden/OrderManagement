using System;
using System.Collections.Generic;

namespace Order.Management
{
    internal class Program
    {
        // Main entry
        public static void Main(string[] args)
        {
            var (customerName, address, dueDate) = CustomerInfoInput();

            var orderedShapes = CustomerOrderInput();

            // This needs a proper way to generate it, but for this
            // example we'll leave it hardcoded
            const int orderNumber = 1235;

            var customerOrder = new Order(customerName, address, dueDate, orderNumber, orderedShapes);

            GenerateReports(customerOrder);
        }

        // Order Circle Input
        private static Circle OrderCirclesInput()
        {
            Console.Write("\nPlease input the number of Red Circle: ");
            var redCircle = Convert.ToInt32(userInput());
            Console.Write("Please input the number of Blue Circle: ");
            var blueCircle = Convert.ToInt32(userInput());
            Console.Write("Please input the number of Yellow Circle: ");
            var yellowCircle = Convert.ToInt32(userInput());

            var circle = new Circle(redCircle, blueCircle, yellowCircle);
            return circle;
        }

        // Order Squares Input
        private static Square OrderSquaresInput()
        {
            Console.Write("\nPlease input the number of Red Squares: ");
            var redSquare = Convert.ToInt32(userInput());
            Console.Write("Please input the number of Blue Squares: ");
            var blueSquare = Convert.ToInt32(userInput());
            Console.Write("Please input the number of Yellow Squares: ");
            var yellowSquare = Convert.ToInt32(userInput());

            var square = new Square(redSquare, blueSquare, yellowSquare);
            return square;
        }

        // Order Triangles Input
        private static Triangle OrderTrianglesInput()
        {
            Console.Write("\nPlease input the number of Red Triangles: ");
            var redTriangle = Convert.ToInt32(userInput());
            Console.Write("Please input the number of Blue Triangles: ");
            var blueTriangle = Convert.ToInt32(userInput());
            Console.Write("Please input the number of Yellow Triangles: ");
            var yellowTriangle = Convert.ToInt32(userInput());

            var triangle = new Triangle(redTriangle, blueTriangle, yellowTriangle);
            return triangle;
        }

        // User Console Input
        private static string userInput()
        {
            var input = Console.ReadLine();
            while (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("please enter valid details");
                input = Console.ReadLine();
            }

            return input;
        }

        // Generate each type of report
        private static void GenerateReports(Order order)
        {
            var invoiceReport = new InvoiceReport(order, Globals.WideTableWidth);
            invoiceReport.GenerateReport();

            var cuttingListReport = new CuttingListReport(order, Globals.NarrowTableWidth);
            cuttingListReport.GenerateReport();

            var paintingReport = new PaintingReport(order, Globals.WideTableWidth);
            paintingReport.GenerateReport();
        }

        // Get customer Info
        private static (string customerName, string address, string dueDate) CustomerInfoInput()
        {
            Console.Write("Please input your Name: ");
            var customerName = userInput();
            Console.Write("Please input your Address: ");
            var address = userInput();
            Console.Write("Please input your Due Date: ");
            var dueDate = userInput();
            return (customerName, address, dueDate);
        }

        // Get order input
        private static List<Shape> CustomerOrderInput()
        {
            var square = OrderSquaresInput();
            var triangle = OrderTrianglesInput();
            var circle = OrderCirclesInput();

            var orderedShapes = new List<Shape>
            {
                square,
                triangle,
                circle
            };
            return orderedShapes;
        }
    }
}