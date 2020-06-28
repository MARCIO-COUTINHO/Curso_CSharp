using composition3.Entities;
using composition3.Entities.Enums;
using System;

namespace composition3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, date);

            Console.WriteLine("Enter order data:");
            Console.WriteLine("Status: PENDING_PAYMENT, PROCESSING , SHIPPED , DELIVERED");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(date, status);
            order.Moment = DateTime.Now;
            order.Client = client;

            Console.Write("How many items to this order? ");
            int qtde = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtde; i++)
            {
                Console.WriteLine($"Enter #" + i);
                Console.Write("Product name: ");
                name = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());
                Product product = new Product(name, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem orderitem = new OrderItem(quantity, price);
                orderitem.Product = product;
                order.items.Add(orderitem);
            }
            Console.WriteLine(order.ToString());
        }
    }
}
