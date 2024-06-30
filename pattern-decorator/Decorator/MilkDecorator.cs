using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_decorator.Decorator
{
    public class MilkDecorator : BeverageDecorator
    {
        public MilkDecorator(Beverage baseBeverage) : base(baseBeverage)
        {
        }

        protected override string GetExtraDescription()
        {
            return "with milk";
        }

        protected override double GetExtraCost()
        {
            return 0.5;
        }

        protected override string GetExtraPreparation()
        {
            return "Adding milk...";
        }
    }
}
