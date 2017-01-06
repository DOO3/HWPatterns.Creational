using System.Collections;

namespace HWPatternsCreational.Builder.Products
{
    public class Pizza
    {
        private readonly ArrayList _parts = new ArrayList();

        public void Add(object part)
        {
            _parts.Add(part);
        }

        public override string ToString()
        {
            string str = "";
            foreach (var part in _parts)
            {
                str += part + "\n";
            }
            return str;
        }
    }
}
