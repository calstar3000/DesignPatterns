
namespace DesignPatterns.Patterns.Structural.Bridge
{
    /// <summary>
    /// The class representes the robot. The key here is that its movement
    /// has been delegated to another class, so that its implmentation can
    /// change without affecting this class (as long as the interface stays
    /// the same).
    /// </summary>
    public class RobotAbstraction
    {
        /// <summary>
        /// The movement of the robot is delegated to another class
        /// </summary>
        public RobotMovementAbstraction Movement { get; set; }

        private string _name;

        public RobotAbstraction(string name)
        {
            _name = name;
        }

        // Each movement operation is called on the delegate class

        public virtual void MoveForwards()
        {
            Movement.MoveForwards();
        }

        public virtual void MoveBackwards()
        {
            Movement.MoveBackwards();
        }

        public virtual void MoveLeft()
        {
            Movement.MoveLeft();
        }

        public virtual void MoveRight()
        {
            Movement.MoveRight();
        }

        public virtual void Jump()
        {
            Movement.Jump();
        }
    }
}
