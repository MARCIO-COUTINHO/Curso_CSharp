namespace Heranca8.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }
        public override double tax()
        {
            if (NumberOfEmployees > 10)
                return 0.14 * anualIncome;
            else
                return 0.16 * anualIncome;
        }
        public override string ToString()
        {
            return Name + ": $ " + tax().ToString("F2");
        }
    }
}
