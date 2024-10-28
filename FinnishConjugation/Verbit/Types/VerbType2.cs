using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinnishConjugation.Verbit;

namespace FinnishInflectionEngine.Verbit.Types
{
    public class VerbType2 : VerbType
    {
        public override List<string> Endings => new List<string>()
        {
            "da", "dä"
        };

        public override IPositiveVerbTense GetPresent(string infinitive) => throw new NotImplementedException();
    }
}
