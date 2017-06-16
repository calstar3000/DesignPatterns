using System;

namespace DesignPatterns.Patterns.Structural.Facade
{
    /// <summary>
    /// One of the facade subsystems: the reference check
    /// </summary>
    public class ReferenceCheck
    {
        public void PerformReferenceCheck()
        {
            Console.WriteLine("The candidate has good references from former colleagues");
        }
    }
}
