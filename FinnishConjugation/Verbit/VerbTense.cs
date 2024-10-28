namespace FinnishInflectionEngine.Verbit
{
    public interface IVerbTense
    {
        string FirstPersonSingular { get;  }
        string FirstPersonPlural { get; }
    }

    public interface IPositiveVerbTense : IVerbTense
    {
        IVerbTense Negative { get; }
    }
}