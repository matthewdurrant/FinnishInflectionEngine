using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinnishInflectionEngine.Verbit;
using FinnishInflectionEngine.Verbit.Types;

namespace FinnishConjugation.Verbit.Tests
{
    [TestClass()]
    public class VerbTests
    {
        [TestMethod()]
        [DataRow("sataa", typeof(VerbType1))]
        [DataRow("tietää", typeof(VerbType1))]
        [DataRow("saada", typeof(VerbType2))]
        [DataRow("syödä", typeof (VerbType2))]
        [DataRow("tulla", typeof(VerbType3))]
        [DataRow("mennä", typeof(VerbType3))]
        [DataRow("haluta", typeof(VerbType4))]
        [DataRow("herätä", typeof(VerbType4))]
        [DataRow("häiritä", typeof(VerbType5))]
        [DataRow("tarvita", typeof(VerbType5))]
        [DataRow("kuumeta", typeof(VerbType6))]
        [DataRow("kylmetä", typeof(VerbType6))]
        public void MatchTest(string verb, Type expectedType)
        {
            VerbType verbType = VerbMatcher.GetVerbType(verb);

            Assert.IsInstanceOfType(verbType, expectedType);
        }

        [TestMethod()]
        [DataRow("sataa", "sadan", "sadamme", "en sada", "emme sada")]
        [DataRow("puhua", "puhun", "puhumme", "en puhu", "emme puhu")]
        [DataRow("laajentaa", "laajennan", "laajennamme", "en laajenna", "emme laajenna")]

        public void Get1stPersonPresent(string infinitive, string sing, string plural, string negSing, string negPlural)
        {
            VerbType1 verb1 = new VerbType1();
            verb1.GetPresent(infinitive);

            Verb verb = new Verb(infinitive);

            Assert.AreEqual(sing, verb.Present.FirstPersonSingular);
            Assert.AreEqual(plural, verb.Present.FirstPersonPlural);
            Assert.AreEqual(negSing, verb.Present.Negative.FirstPersonSingular);
            Assert.AreEqual(negPlural, verb.Present.Negative.FirstPersonPlural);
        }
    }
}