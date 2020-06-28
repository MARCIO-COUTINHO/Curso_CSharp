using System;
using System.Collections.Generic;
using CorrecaoExerciciosFixacao5.Entities;
using System.Globalization;

namespace CorrecaoExerciciosFixacao5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string tipo;
                Console.WriteLine("Product #" + i + " data:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                Product p = new Product();
                Console.WriteLine("Common, used or imported (c/u/i)? ");
                tipo = Console.ReadLine().ToUpper();
                p.Name = name;
                p.Price = price;
                if (tipo == "C")
                {
                    list.Add(p);
                }
                else if (tipo == "I")
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    ImportedProduct ip = new ImportedProduct();
                    ip.CustomsFee = customsFee;
                    ip.Name = name;
                    ip.Price = price;
                    list.Add(ip);
                }
                else if (tipo == "U")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufacturedDate = DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    UsedProduct up = new UsedProduct();
                    up.ManufacturedDate = manufacturedDate;
                    up.Name = name;
                    up.Price = price;
                    list.Add(up);
                }
            }
            Console.WriteLine("PRICE TAGS:");
            foreach (Product p in list)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}
