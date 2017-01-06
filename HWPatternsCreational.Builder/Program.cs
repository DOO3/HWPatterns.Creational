using System;
using HWPatternsCreational.Builder.Builders.Abstract;
using HWPatternsCreational.Builder.Builders.Concrete;

namespace HWPatternsCreational.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Cook cook = new ConcreateCook();
            Director director = new Director();

            director.ConstructTemplate(cook);
            Console.WriteLine(cook.GetResult());


            director.ConstructMargaritaNew(cook);
            Console.WriteLine(cook.GetResult());
        }
    }
}
