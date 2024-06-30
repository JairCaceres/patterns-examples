
using pattern_decorator.Decorator;

namespace pattern_decorator
{
    public class Espresso : Beverage
    {
        public override string Description => "Espresso";

        public override double Cost => 1.5;

        public override string Prepare()
        {
            return "Preparing espresso...";
        }
    }
}
