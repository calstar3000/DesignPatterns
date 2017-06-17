using DesignPatterns.Clients.Interfaces;
using System;

namespace DesignPatterns.Clients
{
    public class VisitorPatternClient : IPatternClient
    {
        public string PatternName
        {
            get { return "Visitor pattern"; }
        }

        public void Run()
        {
            Console.WriteLine("Pattern not implemented");
        }
    }
}
