
namespace DesignPatterns.Patterns.Structural.Bridge
{
    /// <summary>
    /// This class represents the abstraction of the robot's
    /// movement. Any new movement implementation simply
    /// inherits from this class.
    /// </summary>
    public abstract class RobotMovementAbstraction
    {
        public abstract void MoveForwards();
        public abstract void MoveBackwards();
        public abstract void MoveLeft();
        public abstract void MoveRight();
        public abstract void Jump();
    }
}
