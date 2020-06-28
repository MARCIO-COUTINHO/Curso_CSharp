namespace CorrecaoExerciciosFixacao5.Entities
{
    class Product { 
        public string Name { get; set; }
        public double Price { get; set; }

        public virtual string PriceTag()
        {
            return Name + "$ " + Price;
        }

    }
}
