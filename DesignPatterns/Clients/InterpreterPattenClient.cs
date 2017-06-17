using DesignPatterns.Clients.Interfaces;
using System;

namespace DesignPatterns.Clients
{
    public class InterpreterPattenClient : IPatternClient
    {
        public string PatternName
        {
            get { return "Interpreter pattern"; }
        }

        public void Run()
        {
            Console.WriteLine("Pattern not implemented");
        }
    }
}
