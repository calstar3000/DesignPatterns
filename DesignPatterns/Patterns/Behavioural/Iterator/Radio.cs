using System;

namespace DesignPatterns.Patterns.Behavioural.Iterator
{
    /// <summary>
    /// This class represents a radio, which has a number of stations programmed into it.
    /// The various stations are then iterated through in a default way (different iteration
    /// methods can be added as needed).
    /// </summary>
    public class Radio
    {
        public void AddStations()
        {
            Console.WriteLine("Adding stations...\n");

            var stations = new RadioStations();
            stations[0] = new RadioStation("Radioactive", 80.1);
            stations[1] = new RadioStation("Hauraki", 87.5);
            stations[2] = new RadioStation("ZM", 90.9);
            stations[3] = new RadioStation("The Edge", 91.7);
            stations[4] = new RadioStation("National", 101.5);

            var iterator = stations.CreateIterator();

            Console.WriteLine("Cycling through stations...\n");

            for (var station = iterator.First(); !iterator.IsDone; station = iterator.Next())
            {
                Console.WriteLine(station.Display);
            }
        }
    }
}
