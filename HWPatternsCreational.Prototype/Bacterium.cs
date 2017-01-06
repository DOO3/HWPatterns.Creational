using System;

namespace HWPatternsCreational.Prototype
{
    public class Bacterium : ICloneable
    {
        public string Name;

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
