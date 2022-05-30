using System.Collections.Generic;

namespace Order.Management
{
    public class Order
    {
        public Order(string customerName, string address, string dueDate, int orderNumber, List<Shape> orderedBlocks)
        {
            CustomerName = customerName;
            Address = address;
            DueDate = dueDate;
            OrderNumber = orderNumber;
            OrderedBlocks = orderedBlocks;
        }

        private string CustomerName { get; }
        public string Address { get; }
        public string DueDate { get; }
        public int OrderNumber { get; }
        public List<Shape> OrderedBlocks { get; }

        public override string ToString()
        {
            return "\nName: " + CustomerName + " Address: " + Address + " Due Date: " + DueDate + " Order #: " +
                   OrderNumber;
        }
    }
}