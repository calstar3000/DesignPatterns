using DesignPatterns.Clients;
using DesignPatterns.Clients.Interfaces;
using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    /// <summary>
    /// This class runs through the various design pattern demos
    /// by taking user input and running the corresponding demo.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var patterns = new Dictionary<int, IPatternClient>();

            // Each new pattern is added here
            patterns.Add(1, new FactoryPatternClient());
            patterns.Add(2, new BuilderPatternClient());
            patterns.Add(3, new SingletonPatternClient());
            patterns.Add(4, new PrototypePatternClient());

            foreach (var key in patterns.Keys)
            {
                Console.WriteLine(string.Format("Press {0} for {1}", key, patterns[key].PatternName));
            }

            string input = Console.ReadLine();
            int keyCode;
            IPatternClient client;
            if (Int32.TryParse(input, out keyCode) && patterns.TryGetValue(keyCode, out client))
            {
                patterns[keyCode].Run();
            }
            else
            {
                Console.WriteLine("Pattern not found!");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
