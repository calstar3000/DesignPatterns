using DesignPatterns.Clients.Interfaces;
using DesignPatterns.Patterns.Behavioural.TemplateMethod;

namespace DesignPatterns.Clients
{
    /// <summary>
    /// Client of the template method pattern. This example simulates a match day
    /// for a number of different sports. Each sports match is played in the same
    /// general way, with some sports customising some of the steps along the way.
    /// </summary>
    public class TemplateMethodPatternClient : IPatternClient
    {
        public string PatternName
        {
            get { return "Template method pattern"; }
        }

        public void Run()
        {
            new GameDay().Commence();
        }
    }
}
