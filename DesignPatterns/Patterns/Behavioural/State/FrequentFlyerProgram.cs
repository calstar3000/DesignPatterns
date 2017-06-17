namespace DesignPatterns.Patterns.Behavioural.State
{
    /// <summary>
    /// Class representing the frequent flyer program. In this example,
    /// a frequent flyer named Anne earns and spends points, changing
    /// her membership status in the process.
    /// </summary>
    public class FrequentFlyerProgram
    {
        public void Start()
        {
            var anne = new FrequentFlyer("Anne");
            anne.GetStatus();

            anne.EarnPoints(100);
            anne.GetStatus();

            anne.EarnPoints(500);
            anne.GetStatus();

            anne.SpendPoints(400);
            anne.GetStatus();

            anne.EarnPoints(1000);
            anne.GetStatus();

            anne.SpendPoints(1100);
            anne.GetStatus();
        }
    }
}
