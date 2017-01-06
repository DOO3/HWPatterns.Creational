using HWPatternsCreational.Builder.Builders.Abstract;

namespace HWPatternsCreational.Builder
{
    public class Director
    {
        public void ConstructMargarita(Cook cook)
        {
            cook.AddDough();
            cook.AddCheese();
            cook.AddTomatoes();
        }

        public void ConstructMargaritaNew(Cook cook)
        {
            cook.AddDough();
            cook.AddTomatoes();
            cook.AddCheese();
        }

        public void ConstructTemplate(Cook cook)
        {
            cook.AddDough();
        }
    }
}
