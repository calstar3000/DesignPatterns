using DesignPatterns.Clients.Interfaces;
using System;

namespace DesignPatterns.Clients
{
    public class TemplateMethodPatternClient : IPatternClient
    {
        public string PatternName
        {
            get { return "Template method pattern"; }
        }

        public void Run()
        {
            Console.WriteLine("Pattern not implemented");
        }
    }
}
