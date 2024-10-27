using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinnishConjugation.Verbit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}