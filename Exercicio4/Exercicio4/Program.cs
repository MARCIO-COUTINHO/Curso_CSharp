using System;
using System.Globalization;

namespace Exercicio4 {
    class Program {
        static void Main(string[] args) {
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double area = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine("Area = " + area.ToString("F4"),CultureInfo.InvariantCulture); 
        }
    }
}
