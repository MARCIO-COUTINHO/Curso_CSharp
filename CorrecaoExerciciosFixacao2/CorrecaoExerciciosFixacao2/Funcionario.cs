using System.Globalization;

namespace CorrecaoExerciciosFixacao2 {
    class Funcionario {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido() {
            return Salario - Imposto;
        }
        public void AumentarSalario(double porcentagem) {
            Salario = Salario * (1 + porcentagem / 100);
        }
        public override string ToString() {
            return "Funcionário: " + Nome + ", $ " + SalarioLiquido().ToString("F2");
        }

    }
}
