using System;

namespace DesignPatterns.Patterns.Behavioural.State
{
    /// <summary>
    /// An example of a state in the frequent flier program.
    /// This class stores a reference to its owner (the member),
    /// and can update its state to a new state when points are
    /// earned or spent, based on different thresholds.
    /// </summary>
    public class StateBronze : State
    {
        public StateBronze(FrequentFlyer flyer, int points)
        {
            this.Name = "Bronze";
            this.Points = points;
            this.Flyer = flyer;
        }

        public override void EarnPoints(int amount)
        {
            this.Points += amount;
            CheckForStateChange();
        }

        public override void SpendPoints(int amount)
        {
            this.Points -= amount;
            CheckForStateChange();
        }

        public override void CheckForStateChange()
        {
            if (this.Points >= 1000)
            {
                this.Flyer.State = new StateGold(this.Flyer, this.Points);
                Console.WriteLine(string.Format("{0} went from {1} to {2}.", this.Flyer.Name, this.Name, this.Flyer.State.Name));
            }
            else if (this.Points >= 500)
            {
                this.Flyer.State = new StateSilver(this.Flyer, this.Points);
                Console.WriteLine(string.Format("{0} went from {1} to {2}.", this.Flyer.Name, this.Name, this.Flyer.State.Name));
            }
        }
    }
}
