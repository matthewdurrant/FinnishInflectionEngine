namespace FinnishInflectionEngine.Verbit.Tenses
{
    internal class VerbType1PresentNegative : VerbType1Present
    {
        public VerbType1PresentNegative(string infinitive)
        {
            Infinitive = infinitive;
        }

        public override string FirstPersonSingular => $"en {GradateStem()}";

        public override string FirstPersonPlural => $"emme {GradateStem()}";
    }
}