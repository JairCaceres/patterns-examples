using pattern_builder.Interfaces;
using pattern_builder.Models;
namespace pattern_builder.Builders
{
    public class PizzaBuilder : BuilderInterface
    {
        private Product pizza;

        public PizzaBuilder()
        {
            pizza = new Product();
        }

        public void SetDoughType(string doughType)
        {
            pizza.DoughType = doughType;
        }

        public void AddIngredient(string ingredient)
        {

            pizza.Ingredients = pizza.Ingredients == null ? new List<string>() : pizza.Ingredients;
            pizza.Ingredients.Add(ingredient);                
        }

        public void SetPrice(decimal price)
        {
            pizza.Price = price;
        }

        public Product GetProduct()
        {
            return pizza;
        }
    }
}
