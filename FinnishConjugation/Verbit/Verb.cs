using FinnishConjugation.Verbit;
using FinnishInflectionEngine.Verbit.Tenses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinnishInflectionEngine.Verbit
{
    public class Verb
    {
        public string Infinitive { get; }

        public VerbType VerbType { get; }

        public string HasGraduation { get; set; }

        public IPositiveVerbTense Present => VerbType.GetPresent(Infinitive);

        public Verb(string infinitive) 
        { 
            Infinitive = infinitive;
            VerbType = VerbMatcher.GetVerbType(infinitive);
        }
    }
}
