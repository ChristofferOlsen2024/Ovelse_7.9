using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovelse_7._9
{
    internal class By
    {
        public string? Navn;
        public int Indbyggerantal;

        public By(string navn)
        {
            Navn = navn;
        }

        public By(string navn, int indbyggertal)
        {
            Navn = navn;
            Indbyggerantal = indbyggertal;
        }
    }
}
