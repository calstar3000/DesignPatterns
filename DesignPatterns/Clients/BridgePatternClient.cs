using DesignPatterns.Clients.Interfaces;
using DesignPatterns.Patterns.Structural.Bridge;
using System;

namespace DesignPatterns.Clients
{
    /// <summary>
    /// Client of the Bridge pattern. This example simulates a robot with two separate
    /// implementations for its movement (one with legs and one without). Now we can
    /// change the implementation for how the robot moves with legs (or without),
    /// without affecting the robot itself, as the implementation is independent.
    /// </summary>
    public class BridgePatternClient : IPatternClient
    {
        public string PatternName
        {
            get { return "Bridge pattern"; }
        }

        public void Run()
        {
            RobotAbstraction robot = new RobotAbstraction("Excelsior 3000");
            robot.Movement = new RobotMovementImplementation();
            Console.WriteLine("Robot's initial movement implemented...\n");

            // Exercise with first implementation
            Exercise(robot);

            Console.WriteLine("\nRobot's legs are destroyed in combat...\n");

            robot.Movement = new RobotMovementImplementationBackup();
            Console.WriteLine("Robot's backup movement implemented...\n");

            // Exercise with second implementation
            Exercise(robot);
        }

        private void Exercise (RobotAbstraction robot)
        {
            robot.MoveForwards();
            robot.MoveBackwards();
            robot.MoveLeft();
            robot.MoveRight();
            robot.Jump();
        }
    }
}
