using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace ExercicioFixacaoListas {
    class Program {
        static void Main(string[] args) {
            int id;
            Console.Write("How many employees will be registered? ");
            int qtde = int.Parse(Console.ReadLine());
            List<Funcionario> list = new List<Funcionario>();

            for (int i = 0; i < qtde; i++) {
                Console.WriteLine("Emplyoee #" + i + ":");
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                list.Add(new Funcionario(id, name, salary));
            }
            Console.WriteLine("Enter the employee id that will have salary increase :");
            id = int.Parse(Console.ReadLine());
            int pos1 = list.FindIndex(x => x.Id == id);
            if (pos1 == -1) {
                Console.WriteLine("This id does not exist!");
            }
            else {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                list[pos1].IncreaseSalary(percentage);
            }

            foreach (Funcionario x in list) {
                Console.WriteLine(x);
            }
        }
    }
}
