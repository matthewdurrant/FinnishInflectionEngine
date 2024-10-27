using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinnishConjugation.Verbit
{
    public class VerbType5 : VerbType
    {
        protected override int EndingLetters => 3;

        public override List<string> Endings => new List<string>()
        {
            "ita", "itä"
        };
    }
}
