using System;

namespace DesignPatterns.Patterns.Structural.Facade
{
    /// <summary>
    /// One of the facade subsystems: the background check
    /// </summary>
    public class BackgroundCheck
    {
        public void PerformBackgroundCheck()
        {
            Console.WriteLine("The candidate has no previous criminal convictions");
        }
    }
}
