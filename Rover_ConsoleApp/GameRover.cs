using System;
using System.Collections.Generic;
using System.Text;
using VehicleModel;

namespace Rover_ConsoleApp
{
    class GameRover
    {
        public static void Main()
        {
            Rover rover = new Rover(0, 0, RoverFacing.North);
            
            while (true)
            {
                var command = Console.ReadLine();
                switch (command)
                {
                    case "L":
                        rover.TurnLeft();
                        break;
                    case "R":
                        rover.TurnRight();
                        break;
                    case "F":
                        rover.MoveForward();
                        break;
                    default:
                        throw new Exception("invalid command");
                }
                Console.WriteLine($"Rover is now at {rover.RoverPositionX}, {rover.RoverPositionY} - facing {rover.RoverFacing}");
            }
        }
    }
}



