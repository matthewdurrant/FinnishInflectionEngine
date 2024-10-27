using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinnishConjugation.Verbit
{
    public abstract class VerbType : IVerbType
    {
        public virtual List<string> Endings { get; }

        protected virtual int EndingLetters => 2;

        public virtual bool Match(string perusVerbi)
        {
            string ending = perusVerbi.Substring(perusVerbi.Length - EndingLetters, EndingLetters);
            return Endings.Contains(ending);
        }
    }
}
