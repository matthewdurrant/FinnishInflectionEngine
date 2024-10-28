using FinnishInflectionEngine.Verbit.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinnishConjugation.Verbit
{
    public static class VerbMatcher
    {
        static readonly List<VerbType> VerbTypes = new List<VerbType>()
        {
            new VerbType1(),
            new VerbType2(),
            new VerbType3(),
            new VerbType4(),
            new VerbType5(),
            new VerbType6()
        };

        public static VerbType GetVerbType(string verb)
        {
            verb = verb.ToLower().Trim();

            foreach (var verbType in VerbTypes)
            {
                if (verbType.Match(verb)) return verbType;
            }

            throw new NotImplementedException("Verb was not recognised.");
        }
    }
}
