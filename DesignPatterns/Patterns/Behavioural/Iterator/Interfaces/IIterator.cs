
namespace DesignPatterns.Patterns.Behavioural.Iterator.Interfaces
{
    /// <summary>
    /// The iterator interface, describing the methods a class
    /// requires to implement an iterator over the collection.
    /// </summary>
    public interface IIterator
    {
        RadioStation First();
        RadioStation Next();
        RadioStation Current { get; }
        bool IsDone { get; }
    }
}
