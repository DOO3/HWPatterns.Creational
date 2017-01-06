using HWPatternsCreational.Builder.Products;

namespace HWPatternsCreational.Builder.Builders.Abstract
{
    public abstract class Cook
    {
        public abstract void AddDough();

        public abstract void AddCheese();

        public abstract void AddTomatoes();

        public abstract Pizza GetResult();
    }
}
