using System;
using System.Collections.Generic;
using System.Text;
using composition3.Entities.Enums;
using System.Globalization;

namespace composition3.Entities
{
    class Order
    {
        public Client Client { get; set; }
        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }
        
        public List<OrderItem> items = new List<OrderItem>();

        public Order ()
        {

        }
        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void AddItem (OrderItem item)
        {
            items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            items.Remove(item);
        }
        public double Total ()
        {
            double total = 0;
            foreach (OrderItem x in items)
                total += x.Price * x.Quantity;
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order moment: " + Moment.ToString("dd/mm/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status.ToString());
            sb.AppendLine("Client: "
                + Client.Name
                + "("
                + Client.BirthDate.ToString("dd/MM/yyyy")
                + ")"
                + " - "
                + Client.Email);
            sb.AppendLine("Order items:");
            double total = 0;
            foreach (OrderItem x in items) {
                sb.AppendLine(x.Product.Name
                    + ", $"
                    + x.Product.Price.ToString("F2", CultureInfo.InvariantCulture)
                    + ", Quantity: "
                    + x.Quantity
                    + ", Subtotal: $"
                    + x.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
                total += x.SubTotal();
            }
            sb.AppendLine("Total price: $" + total.ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
