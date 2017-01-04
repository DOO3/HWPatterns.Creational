using HWPatternsCreational.FactoryMethod.Creators.Abstract;
using HWPatternsCreational.FactoryMethod.Products.Abstract;
using HWPatternsCreational.FactoryMethod.Products.Conctrete;

namespace HWPatternsCreational.FactoryMethod.Creators.Conctrete
{
    public class PenCreator : Creator
    {
        public override Product Produce()
        {
            return new Pen();
        }
    }
}
