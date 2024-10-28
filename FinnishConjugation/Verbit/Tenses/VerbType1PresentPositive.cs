using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinnishInflectionEngine.Verbit.Tenses
{
    public class VerbType1PresentPositive : VerbType1Present, IPositiveVerbTense
    {
        public VerbType1PresentPositive(string infinitive)
        {
            Infinitive = infinitive;
            Negative = new VerbType1PresentNegative(Infinitive);
        }

        public IVerbTense Negative { get; }

        public override string FirstPersonSingular => $"{GradateStem()}n";
        public override string FirstPersonPlural => $"{GradateStem()}mme";
    }
}
