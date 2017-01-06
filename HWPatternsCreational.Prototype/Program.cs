using System;

namespace HWPatternsCreational.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Bacterium bacterium = new Bacterium();
            bacterium.Name = "Garry";

            Bacterium bacterium2 = (Bacterium)bacterium.Clone();
            Console.WriteLine(bacterium2.Name);
        }
    }
}
