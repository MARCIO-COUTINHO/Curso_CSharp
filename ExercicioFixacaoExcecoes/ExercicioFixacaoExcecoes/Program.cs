using System;
using System.Globalization;
using ExercicioFixacaoExcecoes.Entities;
using ExercicioFixacaoExcecoes.Exceptions;

namespace ExercicioFixacaoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account acc = new Account(number, holder, balance, withDrawLimit);

                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                acc.WithDraw(amount);
                Console.Write("New balance: " + acc.Balance.ToString("F2"));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error:" + e.Message);
            }
        }
    }
}
