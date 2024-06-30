
using pattern_decorator.Decorator;

namespace pattern_decorator
{
    public class Program
    {
        protected Program() { }
        public static void Main()
        {
            Beverage beverage = new Espresso();
            beverage = new MilkDecorator(beverage);
            beverage = new SugarDecorator(beverage);

            Console.WriteLine("Description: " + beverage.Description);
            Console.WriteLine("Cost: " + beverage.Cost);
            Console.WriteLine("Preparation: " + beverage.Prepare());
        }
    }
}