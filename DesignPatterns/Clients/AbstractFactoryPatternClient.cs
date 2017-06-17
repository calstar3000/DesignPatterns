using DesignPatterns.Clients.Interfaces;
using System;

namespace DesignPatterns.Clients
{
    public class AbstractFactoryPatternClient : IPatternClient
    {
        public string PatternName
        {
            get { return "Abstract factory pattern"; }
        }

        public void Run()
        {
            Console.Write("Pattern not implemented.");
        }
    }
}
