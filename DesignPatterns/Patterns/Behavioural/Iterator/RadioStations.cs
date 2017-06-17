using System.Collections.Generic;

namespace DesignPatterns.Patterns.Behavioural.Iterator
{
    /// <summary>
    /// The class representing the collection of saved radio stations.
    /// Objects can be added an access via the indexer, and an iterator
    /// object looks after how the elements in the collection are iterated
    /// over.
    /// </summary>
    public class RadioStations
    {
        private List<RadioStation> _stations = new List<RadioStation>();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count
        {
            get { return _stations.Count; }
        }

        // Indexer
        public object this[int index]
        {
            get { return _stations[index]; }
            set { _stations.Add((RadioStation)value); }
        }
    }
}
