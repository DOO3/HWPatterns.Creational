using HWPatternsCreational.FactoryMethod.Products.Abstract;

namespace HWPatternsCreational.FactoryMethod.Creators.Abstract
{
    public abstract class Creator
    {
        public abstract Product Produce();
    }
}
