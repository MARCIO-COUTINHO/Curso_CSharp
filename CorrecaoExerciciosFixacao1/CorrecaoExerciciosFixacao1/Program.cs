using System;
using System.Globalization;

namespace CorrecaoExerciciosFixacao1 {
    class Program {
        static void Main(string[] args) {
            Retangulo r = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retângulo:");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = altura;
            r.Largura = largura;
            Console.WriteLine("AREA = " + r.Area().ToString("F2"));
            Console.WriteLine("PERIMETRO = " + r.Perimetro().ToString("F2"));
            Console.WriteLine("DIAGONAL = " + r.Diagonal().ToString("F2"));
        }
    }
}
