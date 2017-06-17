using DesignPatterns.Clients.Interfaces;
using System;

namespace DesignPatterns.Clients
{
    public class StrategyPatternClient : IPatternClient
    {
        public string PatternName
        {
            get { return "Strategy pattern"; }
        }

        public void Run()
        {
            Console.WriteLine("Pattern not implemented");
        }
    }
}
