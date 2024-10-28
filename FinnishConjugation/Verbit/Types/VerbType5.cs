using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinnishConjugation.Verbit;

namespace FinnishInflectionEngine.Verbit.Types
{
    public class VerbType5 : VerbType
    {
        protected override int EndingLetters => 3;

        public override List<string> Endings => new List<string>()
        {
            "ita", "itä"
        };

        public override IPositiveVerbTense GetPresent(string infinitive) => throw new NotImplementedException();
    }
}
