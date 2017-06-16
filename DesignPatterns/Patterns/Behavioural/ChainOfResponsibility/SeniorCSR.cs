using System;

namespace DesignPatterns.Patterns.Behavioural.ChainOfResponsibility
{
    /// <summary>
    /// A senior CSR, capable of handling all but the most critical of requests,
    /// which are recommended to the consumer watchdog.
    /// </summary>
    public class SeniorCSR : CustomerSupportRepresentative
    {
        public SeniorCSR(string name)
            : base(name)
        {
        }

        public override void HandleRequest(SupportRequest request)
        {
            if (request.SeverityLevel <= SeverityLevel.High)
            {
                Console.WriteLine(string.Format("Request of {0} severity handled by senior CSR {1}.", request.SeverityLevel.ToString().ToLower(), _name));
            }
            else
            {
                Console.WriteLine(string.Format("Request could not be handled by our CSR team, please contact consumer watchdog.", _name));
            }
        }
    }
}
