using Beverages;

namespace Condiments
{
    abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;

        protected CondimentDecorator(Beverage beverage) : base(beverage.Description, beverage.Cost)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription();
        }

        public override double GetCost()
        {
            return beverage.GetCost();
        }
    }

    class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Leche";
        }

        public override double GetCost()
        {
            return beverage.GetCost() + 10;
        }
    }

    class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soja";
        }

        public override double GetCost()
        {
            return beverage.GetCost() + 15;
        }
    }

    class Chocolate : CondimentDecorator
    {
        public Chocolate(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Chocolate";
        }

        public override double GetCost()
        {
            return beverage.GetCost() + 13;
        }
    }

    class WhippedCream : CondimentDecorator
    {
        public WhippedCream(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Crema batida";
        }

        public override double GetCost()
        {
            return beverage.GetCost() + 12;
        }
    }
}
