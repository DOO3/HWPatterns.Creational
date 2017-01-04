using HWPatternsCreational.FactoryMethod.Creators.Abstract;
using HWPatternsCreational.FactoryMethod.Creators.Conctrete;
using HWPatternsCreational.FactoryMethod.Products.Abstract;

namespace HWPatternsCreational.FactoryMethod
{
    internal class Program
    {
        private static void Main()
        {
            Creator creator = new PenCreator();
            Product pen = creator.Produce();

            creator = new NotebookCreator();
            Product notebook = creator.Produce();
        }
    }
}
