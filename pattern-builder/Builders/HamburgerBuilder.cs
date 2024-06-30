using pattern_builder.Interfaces;
using pattern_builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_builder.Builders
{
    public class HamburgerBuilder : BuilderInterface
    {
        private Product hamburger;

        public HamburgerBuilder()
        {
            hamburger = new Product();
        }

        public void SetDoughType(string bunType)
        {
            hamburger.DoughType = bunType;
        }

        public void AddIngredient(string ingredient)
        {
            hamburger.Ingredients = hamburger.Ingredients == null ? new List<string>() : hamburger.Ingredients;
            hamburger.Ingredients.Add(ingredient);
        }

        public void SetPrice(decimal price)
        {
            hamburger.Price = price;
        }

        public Product GetProduct()
        {
            return hamburger;
        }
    }
}
