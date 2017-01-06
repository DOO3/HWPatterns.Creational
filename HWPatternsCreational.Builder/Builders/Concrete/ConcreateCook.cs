using HWPatternsCreational.Builder.Builders.Abstract;
using HWPatternsCreational.Builder.Products;
using HWPatternsCreational.Builder.Products.Parts;

namespace HWPatternsCreational.Builder.Builders.Concrete
{
    public class ConcreateCook : Cook
    {
        private Pizza _pizza = new Pizza();

        public override void AddCheese() { _pizza.Add(new Cheese()); }

        public override void AddDough() { _pizza.Add(new Dough()); }

        public override void AddTomatoes() { _pizza.Add(new Tomatoes()); }

        public override Pizza GetResult()
        {
            var res = _pizza;
            _pizza = new Pizza();
            return res;
        }
    }
}
