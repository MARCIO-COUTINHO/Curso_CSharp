using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacaoListas {
    class Funcionario {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salary { get; set; }

        public Funcionario(int id, string nome, double salary) {
            Nome = nome;
            Id = id;
            Salary = salary;
        }

        public void IncreaseSalary (double percentage) {
            Salary *= (1 + percentage / 100);
        }

        public override string ToString() {
            return Id + ", " + Nome + ", " + Salary;
        }
    }
}

