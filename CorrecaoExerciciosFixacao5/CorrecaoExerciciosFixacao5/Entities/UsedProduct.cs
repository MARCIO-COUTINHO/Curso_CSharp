using System;
using System.Globalization;

namespace CorrecaoExerciciosFixacao5.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufacturedDate { get; set; }
        public override string PriceTag()
        {
            return Name +
                    "(used) $ " +
                    Price.ToString("F2", CultureInfo.InvariantCulture) +
                    "(Manufacture date: " + ManufacturedDate.ToString("dd/MM/yyyy") +
                    ")";
        }
    }
}
