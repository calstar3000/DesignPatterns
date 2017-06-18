
namespace DesignPatterns.Patterns.Creational.AbstractFactory
{
    /// <summary>
    /// The template for the factory
    /// </summary>
    public abstract class AbstractFactory
    {
        public abstract void CreateSwordsman();
        public abstract void CreateArcher();
    }
}
