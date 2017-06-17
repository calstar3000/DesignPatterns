using DesignPatterns.Clients.Interfaces;
using System;

namespace DesignPatterns.Clients
{
    public class ObserverPatternClient : IPatternClient
    {
        public string PatternName
        {
            get { return "Observer pattern"; }
        }

        public void Run()
        {
            Console.WriteLine("Pattern not implemented");
        }
    }
}
