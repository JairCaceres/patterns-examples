using pattern_builder.Interfaces;

namespace pattern_builder.Builders
{
    public class Builder
    {
        private BuilderInterface builder;

        public Builder(BuilderInterface builder)
        {
            this.builder = builder;
        }

        public void BuildClassicPizza()
        {
            builder.SetDoughType("Thin");
            builder.AddIngredient("Tomato");
            builder.AddIngredient("Mozzarella");
            builder.SetPrice(15000m);
        }

        public void BuildDoubleCheeseHamburger()
        {
            builder.SetDoughType("Brioche");
            builder.AddIngredient("Beef");
            builder.AddIngredient("Cheddar");
            builder.AddIngredient("Lettuce");
            builder.AddIngredient("Tomato");
            builder.SetPrice(10000m);

        }
    }
}
