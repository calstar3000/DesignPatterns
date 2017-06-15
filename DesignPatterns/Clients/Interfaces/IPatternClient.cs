
namespace DesignPatterns.Clients
{
    /// <summary>
    /// Defines an interfaces for how a client of a design pattern should behave
    /// </summary>
    public interface IPatternClient
    {
        /// <summary>
        /// The name of the design pattern
        /// </summary>
        string PatternName { get; }

        /// <summary>
        /// Run the design pattern demo
        /// </summary>
        void Run();
    }
}
