using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinnishConjugation.Verbit;
using FinnishInflectionEngine.Verbit.Tenses;

namespace FinnishInflectionEngine.Verbit.Types
{
    public class VerbType1 : VerbType
    {
        public override IPositiveVerbTense GetPresent(string infinitive) => new VerbType1PresentPositive(infinitive);

        public override List<string> Endings => new List<string>()
        {
            "aa", "ea", "eä", "ia", "iä", "oa", "ua", "yä", "ää", "öä"
        };
    }
}
