using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinnishInflectionEngine.Verbit.Tenses
{
    public class VerbType1Present : IVerbTense
    {
        protected string Infinitive { get; set; }

        public string Stem => Infinitive.Substring(0, Infinitive.Length - 1);

        public string GradateStem()
        {
            string startLetter = Stem.Substring(0, 1);
            string gradatedStemEnd = Stem.Substring(1);
            foreach ((string, string) pair in ConsonantChanges)
            {
                if (gradatedStemEnd.Contains(pair.Item1))
                {
                    gradatedStemEnd = gradatedStemEnd.Replace(pair.Item1, pair.Item2);
                    return $"{startLetter}{gradatedStemEnd}";
                }
            }

            return $"{startLetter}{gradatedStemEnd}";
        }

        private List<(string, string)> ConsonantChanges { get; }
            = new List<(string, string)>()
            {
                ("kk","k"),
                ("pp","p"),
                ("tt","t"),
                ("nt","nn"),
                ("nk","ng"),
                ("mp","mm"),
                ("lt","ll"),
                ("rt","rr"),
                ("t","d"),
                ("k",""),
                ("p","v"),
                ("lke","lje"),
                ("rke","rje")
            };

        public virtual string FirstPersonSingular => $"{GradateStem}n";
        public virtual string FirstPersonPlural => $"{GradateStem}mme";
    }
}
