using System;

namespace DesignPatterns.Patterns.Structural.Facade
{
    /// <summary>
    /// One of the facade subsystems: the resume check
    /// </summary>
    public class ResumeCheck
    {
        public void PerformResumeCheck()
        {
            Console.WriteLine("The candidate's CV has no spelling mistakes");
        }
    }
}
