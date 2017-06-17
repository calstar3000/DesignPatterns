using DesignPatterns.Clients.Interfaces;
using System;

namespace DesignPatterns.Clients
{
    public class StatePatternClient : IPatternClient
    {
        public string PatternName
        {
            get { return "State pattern"; }
        }

        public void Run()
        {
            Console.WriteLine("Pattern not implemented");
        }
    }
}
