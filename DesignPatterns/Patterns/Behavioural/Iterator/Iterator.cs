using DesignPatterns.Patterns.Behavioural.Iterator.Interfaces;

namespace DesignPatterns.Patterns.Behavioural.Iterator
{
    /// <summary>
    /// Concrete implementation of the iterator interface.
    /// First: access the first element in the collection
    /// Next: access the next element in the collection
    /// Current: access the current element in the collection
    /// IsDone: are we finished iterating over the collection?
    /// </summary>
    public class Iterator : IIterator
    {
        private RadioStations _radioStations;
        private int _index;

        public Iterator(RadioStations radioStations)
        {
            _radioStations = radioStations;
            _index = 0;
        }

        public RadioStation First()
        {
            _index = 0;
            return (RadioStation)_radioStations[_index];
            
        }

        public RadioStation Next()
        {
            _index += 1;

            if (IsDone)
            {
                return null;
            }
            else
            {
                return (RadioStation)_radioStations[_index];
            }
        }

        public RadioStation Current
        {
            get { return (RadioStation)_radioStations[_index]; }
        }

        public bool IsDone
        {
            get { return _index >= _radioStations.Count; }
        }
    }
}
