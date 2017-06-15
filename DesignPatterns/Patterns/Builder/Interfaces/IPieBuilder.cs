
namespace DesignPatterns.Patterns.Builder.Interfaces
{
    /// <summary>
    /// The contract that all Builders must adhere to, ie. all the steps required to build a pie
    /// </summary>
    public interface IPieBuilder
    {
        Pie PieInstance { get; }

        void MakePastry();
        void AddFilling();
        void AddToppig();
    }
}
