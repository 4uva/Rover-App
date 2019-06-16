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
            PlayGround playGround = new PlayGround(0, 0, 3, 3);
            Rover rover = new Rover(new Position(0, 0), RoverFacing.North, playGround);
            
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
                Console.WriteLine($"Rover is now at {rover.Position.X}, {rover.Position.Y} - facing {rover.Facing}");
            }
        }
    }
}



