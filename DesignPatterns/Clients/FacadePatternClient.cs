using DesignPatterns.Clients.Interfaces;
using DesignPatterns.Patterns.Structural.Facade;

namespace DesignPatterns.Clients
{
    /// <summary>
    /// The client of the facade pattern. In this example it provides an interface
    /// for a job application program, which needs to perform different checks on
    /// the applicant across a number of different subsystems.
    /// </summary>
    public class FacadePatternClient : IPatternClient
    {
        public string PatternName
        {
            get { return "Facade pattern"; }
        }

        public void Run()
        {
            new JobApplicationFacade().ProcessJobApplication();
        }
    }
}
