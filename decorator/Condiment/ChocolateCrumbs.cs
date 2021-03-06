using decorator.Beverage;

namespace decorator.Condiment
{
    public class ChocolateCrumbs : CondimentDecorator
    {
        private readonly uint _mass;
        
        public ChocolateCrumbs(IBeverage beverage, uint mass) : base(beverage)
        {
            _mass = mass;
        }

        protected override double GetCondimentCost() => 2.0 * _mass;

        protected override string GetCondimentDescription() => "Chocolate crumbs " + _mass + "g";
    }
}