using System;
using System.Globalization;

namespace Exercicio2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com seu nome completo:");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] v = Console.ReadLine().Split(' ');
            string ultimoNome = v[0];
            int idade = int.Parse(v[1]);
            double altura = double.Parse(v[2],CultureInfo.InvariantCulture);
            Console.WriteLine(nomeCompleto);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2"),CultureInfo.InvariantCulture);
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2"),CultureInfo.InvariantCulture);
        }
    }
}
