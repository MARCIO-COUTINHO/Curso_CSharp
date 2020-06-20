using System;

namespace CorrecaoExerciciosFixacao4 {
    class Program {
        static void Main(string[] args) {
            Conta c;
            double quantia;
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial(s / n) ? ");
            char opcao = char.Parse(Console.ReadLine());

            if (opcao == 'S' || opcao == 's') {
                Console.Write("Entre o valor de depósito inicial: ");
                quantia = double.Parse(Console.ReadLine());
                c = new Conta(nome, numero, quantia);
            }
            else {
                c = new Conta(nome, numero);
            }
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(c);
            Console.Write("Entre com um valor para depósito: ");
            quantia = double.Parse(Console.ReadLine());
            c.Deposito(quantia);
            Console.WriteLine("Dados da Conta atualizados:");
            Console.WriteLine(c);
            Console.Write("Entre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine());
            c.Saque(quantia);
            Console.WriteLine("Dados da Conta atualizados:");
            Console.WriteLine(c);
        }
    }
}
