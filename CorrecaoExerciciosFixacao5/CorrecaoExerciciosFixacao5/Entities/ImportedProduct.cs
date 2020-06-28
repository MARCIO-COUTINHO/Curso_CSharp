using System.Globalization;

namespace CorrecaoExerciciosFixacao5.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public double totalPrice ()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag() {
            return Name + "$ " + Price.ToString("F2",CultureInfo.InvariantCulture) + "(Customs fee: $ " + CustomsFee;
        }
    }
}
