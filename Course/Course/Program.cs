using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            sbyte x = 100;
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "MARIA";
            object obj1 = "MARCIO";
            object obj2 = 4.5;

            Console.WriteLine(completo);
            Console.WriteLine(x);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(decimal.MaxValue);
            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");
            Console.WriteLine("-----------------------------");

            int idade = 32;
            double saldo = 10.35784;
            Console.WriteLine(genero);
            Console.WriteLine(nome);
            Console.WriteLine(saldo);
            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            Console.WriteLine(($"{nome} tem {idade} anos e tem saldo de {saldo:F2} reais"));
            Console.WriteLine(nome + " tem " + idade + " anos " + "e tem saldo de " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
        }
    }
}
