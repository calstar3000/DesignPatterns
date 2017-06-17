
namespace DesignPatterns.Patterns.Behavioural.State
{
    /// <summary>
    /// The template for the different states in the frequent flyer
    /// program (bronze, silver, gold).
    /// </summary>
    public abstract class State
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public FrequentFlyer Flyer { get; set; }

        public abstract void EarnPoints(int amount);
        public abstract void SpendPoints(int amount);
        public abstract void CheckForStateChange();
    }
}
