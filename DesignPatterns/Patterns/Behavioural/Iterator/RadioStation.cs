
namespace DesignPatterns.Patterns.Behavioural.Iterator
{
    /// <summary>
    /// Represents a radio station, or a single item in the collection
    /// to be iterated over.
    /// </summary>
    public class RadioStation
    {
        private string _name;
        private double _frequency;

        public RadioStation(string name, double frequency)
        {
            _name = name;
            _frequency = frequency;
        }

        public string Display
        {
            get { return string.Format("{0} at {1}", _name, _frequency); }
        }
    }
}
