using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinnishConjugation.Verbit
{
    public class VerbType2 : VerbType
    {
        public override List<string> Endings => new List<string>()
        {
            "da", "dä"
        };
    }
}
