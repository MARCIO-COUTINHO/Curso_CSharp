using System;

namespace Exercicio6 {
    class Program {
        static void Main(string[] args) {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            Console.WriteLine("DIFERENÇA = " + (n1 * n2 - n3 * n4));
        }
    }
}
