using DesignPatterns.Clients.Interfaces;
using System;

namespace DesignPatterns.Clients
{
    public class MediatorPatternClient : IPatternClient
    {
        public string PatternName
        {
            get { return "Mediator pattern"; }
        }

        public void Run()
        {
            Console.WriteLine("Pattern not implemented");
        }
    }
}
