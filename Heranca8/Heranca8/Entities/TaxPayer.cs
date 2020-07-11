using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca8.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double anualIncome { get; set; }

        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            this.anualIncome = anualIncome;
        }

        public abstract double tax();
    }
}
