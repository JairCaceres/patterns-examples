
namespace pattern_decorator.Decorator
{
    public abstract class BeverageDecorator : Beverage
    {
        protected Beverage baseBeverage;

        public BeverageDecorator(Beverage baseBeverage)
        {
            this.baseBeverage = baseBeverage;
        }

        public override string Description
        {
            get { return baseBeverage.Description + " " + this.GetExtraDescription(); }
        }

        public override double Cost
        {
            get { return baseBeverage.Cost + this.GetExtraCost(); }
        }

        public override string Prepare()
        {
            return baseBeverage.Prepare() + " " + this.GetExtraPreparation();
        }

        protected abstract string GetExtraDescription();

        protected abstract double GetExtraCost();

        protected abstract string GetExtraPreparation();
    }
}
