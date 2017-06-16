using System;

namespace DesignPatterns.Patterns.Structural.Facade
{
    /// <summary>
    /// The class representing the facade for the job application process.
    /// It calls methods on the various subsystems in order to complete its
    /// objective, which is screen a job applicant.
    /// </summary>
    public class JobApplicationFacade
    {
        private ResumeCheck _resumeCheck;
        private ReferenceCheck _referenceCheck;
        private BackgroundCheck _backgroundCheck;

        public JobApplicationFacade()
        {
            _resumeCheck = new ResumeCheck();
            _referenceCheck = new ReferenceCheck();
            _backgroundCheck = new BackgroundCheck();
        }

        public void ProcessJobApplication()
        {
            Console.WriteLine("Processing job application...");

            _resumeCheck.PerformResumeCheck();
            _referenceCheck.PerformReferenceCheck();
            _backgroundCheck.PerformBackgroundCheck();
        }
    }
}
