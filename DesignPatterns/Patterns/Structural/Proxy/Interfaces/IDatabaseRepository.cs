
namespace DesignPatterns.Patterns.Structural.Proxy.Interfaces
{
    /// <summary>
    /// The interface for the database repository and its proxy.
    /// </summary>
    public interface IDatabaseRepository
    {
        void Create();
        void Read();
        void Update();
        void Delete();
    }
}
