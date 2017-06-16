using System;

namespace DesignPatterns.Patterns.Behavioural.ChainOfResponsibility
{
    /// <summary>
    /// A junior CSR, only capable of handling requests of the lowest severity level.
    /// More severe requests are passed of to an intermediate CSR to handle.
    /// </summary>
    public class JuniorCSR : CustomerSupportRepresentative
    {
        public JuniorCSR(string name)
            : base(name)
        {
        }

        public override void HandleRequest(SupportRequest request)
        {
            if (request.SeverityLevel <= SeverityLevel.Low)
            {
                Console.WriteLine(string.Format("Request of {0} severity handled by junior CSR {1}.", request.SeverityLevel.ToString().ToLower(), _name));
            }
            else
            {
                Console.WriteLine(string.Format("Request of {0} severity not handled by junior CSR {1}. Escalating request...", request.SeverityLevel.ToString().ToLower(), _name));

                _successor.HandleRequest(request);
            }
        }
    }
}
