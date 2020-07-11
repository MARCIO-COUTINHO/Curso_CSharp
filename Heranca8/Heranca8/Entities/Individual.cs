namespace Heranca8.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double tax()
        {
            if (anualIncome < 20000)
                return (0.15 * anualIncome) - (HealthExpenditures / 2);
            else
                return (0.25 * anualIncome) - (HealthExpenditures / 2);
        }
        public override string ToString()
        {
            return Name + ": $ " + tax().ToString("F2");
        }
    }
}
