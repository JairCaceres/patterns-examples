using pattern_builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_builder.Interfaces
{
    public interface BuilderInterface
    {
        void SetDoughType(string doughType);
        void AddIngredient(string ingredient);
        void SetPrice(decimal price);
        Product GetProduct();
    }
}
