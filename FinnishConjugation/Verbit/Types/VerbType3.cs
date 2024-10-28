using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinnishConjugation;
using FinnishConjugation.Verbit;

namespace FinnishInflectionEngine.Verbit.Types
{
    public class VerbType3 : VerbType
    {
        public override IPositiveVerbTense GetPresent(string infinitive) => throw new NotImplementedException();

        /// <summary>
        /// Catch verbs of type 3, e.g. '-lla'
        /// </summary>
        /// <param name="perusVerbi"></param>
        /// <returns></returns>
        public override bool Match(string perusVerbi)
        {
            perusVerbi = perusVerbi.ToLower().Trim();

            string ending = perusVerbi.Substring(perusVerbi.Length - 3, 3);

            // Last character must be a or ä
            List<char> endingVowels = new List<char>() { 'a', 'ä' };
            if (!endingVowels.Contains(ending.Last())) return false;

            // 1st and 2nd characters must be the same
            if (ending[0] != ending[1]) return false;

            // 1st/2nd character cannot be a vowel
            if (!LanguageConstants.Vowels.Contains(ending[0])) return true;

            return false;
        }
    }
}
