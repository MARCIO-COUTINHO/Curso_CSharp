using System;

namespace ExercicioFixacaoVetores {
    class Program {
        static void Main(string[] args) {
            Estudante[] estudantes = new Estudante[10];
            Console.Write("Quantos quartos serão alugados? ");
            int qtde = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtde; i++) {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                int quarto = int.Parse(Console.ReadLine());
                estudantes[quarto] = new Estudante(nome, email);
                Console.WriteLine("Quarto: " + i);
            }
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++) {
                if (estudantes[i] != null) {
                    Console.WriteLine(i
                        + ":"
                        + estudantes[i].Nome
                        + ", "
                        + estudantes[i].Email);
                }
            }
        }
    }
}

