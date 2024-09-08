namespace Beverages
{
    public abstract class Beverage
    {
        protected Beverage(string description, double cost)
        {
            Description = description;
            Cost = cost;
        }

        public string Description { get; }
        public double Cost { get; }

        public virtual string GetDescription()
        {
            return Description;
        }

        public virtual double GetCost()
        {
            return Cost;
        }
    }

    class HouseBlend : Beverage
    {
        public HouseBlend() : base("House Blend: Una mezcla suave y equilibrada de café", 40) { }
    }

    class DarkRoast : Beverage
    {
        public DarkRoast() : base("Dark Roast: Un café oscuro y robusto con un sabor intenso", 45) { }
    }

    class Espresso : Beverage
    {
        public Espresso() : base("Espresso: Un café fuerte y concentrado", 35) { }
    }

    class Decaf : Beverage
    {
        public Decaf() : base("Decaf: Un café descafeinado con todo el sabor", 38) { }
    }
}
