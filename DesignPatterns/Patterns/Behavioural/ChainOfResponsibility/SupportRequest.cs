
namespace DesignPatterns.Patterns.Behavioural.ChainOfResponsibility
{
    /// <summary>
    /// Represents a support request with a level of severity, which will
    /// determine which customer support rep (if any) will handle the request.
    /// </summary>
    public class SupportRequest
    {
        private SeverityLevel _severityLevel;

        public SupportRequest(SeverityLevel severityLevel)
        {
            _severityLevel = severityLevel;
        }

        public SeverityLevel SeverityLevel
        {
            get
            {
                return _severityLevel;
            }
        }
    }
}
