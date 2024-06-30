using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_builder.Models
{
    public class Product
    {
        public string DoughType { get; set; }
        public List<string> Ingredients { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Dough Type: {DoughType}\nIngredients: {string.Join(", ", Ingredients)}\nPrice: {Price:C2}";
        }
    }
}
