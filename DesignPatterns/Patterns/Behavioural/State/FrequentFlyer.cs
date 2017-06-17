using System;

namespace DesignPatterns.Patterns.Behavioural.State
{
    /// <summary>
    /// Class representing a member of the frequent flyer program.
    /// The class delegates its state (and operations on it) to
    /// another class which is also responsible for changing its state
    /// depending on the number of points a member has.
    /// </summary>
    public class FrequentFlyer
    {
        private string _name;
        public State State;

        public string Name { get { return _name; } }
        public int Points { get { return State.Points; } }

        public FrequentFlyer(string name)
        {
            _name = name;
            State = new StateBronze(this, 0);
        }

        public void EarnPoints(int amount)
        {
            Console.WriteLine(string.Format("{0} earned {1} points.", _name, amount));
            State.EarnPoints(amount);
        }

        public void SpendPoints(int amount)
        {
            Console.WriteLine(string.Format("{0} spent {1} points.", _name, amount));
            State.SpendPoints(amount);
        }

        public void GetStatus()
        {
            Console.WriteLine(string.Format("{0} is a {1} member with {2} points.", _name, State.Name, State.Points));
        }
    }
}
