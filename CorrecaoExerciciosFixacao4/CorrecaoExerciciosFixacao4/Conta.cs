using System;

namespace CorrecaoExerciciosFixacao4 {
    class Conta {

        public string Nome { get; set; }
        public int Numero { get; private set; }
        public double Saldo { get; private set; }
        public Conta() { 
        }
        public Conta(string nome, int numero) {
            Nome = nome;
            Numero = numero;
        }
        public Conta(string nome, int numero, double depositoInicial) : this(nome, numero) {
            Deposito(depositoInicial);
        }
        public void Deposito(double quantia) {
            Saldo += quantia;
        }
        public void Saque(double quantia) {
            Saldo -= quantia + 5;
        }
        public override string ToString() {
            return "Conta: " + Numero + ", Titular: " + Nome + ", Saldo: " + Saldo.ToString("F2");
        }
    }
}
