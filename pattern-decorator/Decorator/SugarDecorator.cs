
namespace pattern_decorator.Decorator
{
    public class SugarDecorator : BeverageDecorator
    {
        public SugarDecorator(Beverage baseBeverage) : base(baseBeverage)
        {
        }

        protected override string GetExtraDescription()
        {
            return "with sugar";
        }

        protected override double GetExtraCost()
        {
            return 0.2;
        }

        protected override string GetExtraPreparation()
        {
            return "Adding sugar...";
        }
    }

}
