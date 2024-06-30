using pattern_builder.Builders;
using pattern_builder.Models;
using System.IO;

namespace pattern_builder
{
    public class Program
    {
        protected Program() { }
        static void Main()
        {
            Console.WriteLine("Construyendo una pizza:");
            PizzaBuilder pizzaBuilder = new PizzaBuilder();
            Builder builder = new Builder(pizzaBuilder);
            builder.BuildClassicPizza();
            Product pizza = pizzaBuilder.GetProduct();
            Console.WriteLine(pizza);


            Console.WriteLine("\nConstruyendo una hamburguesa con queso:");
            HamburgerBuilder hamburgerBuilder = new HamburgerBuilder();
            builder = new Builder(hamburgerBuilder);
            builder.BuildDoubleCheeseHamburger();
            Product hamburger = hamburgerBuilder.GetProduct();
            Console.WriteLine(hamburger);
        }
    }
}