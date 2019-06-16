using System;
using System.Collections.Generic;
using System.Text;

using GameModel;
using VehicleModel;

namespace Rover_ConsoleApp
{
    class GameRover
    {
        public static void Main()
        {
            PlayGround playGround = new PlayGround(0, 0, 3, 3);
            Rover rover = new Rover(new Position(0, 0), RoverFacing.North, playGround);
            Game game = new Game(rover, Console.In, Console.Out);

            while (true)
            {
                game.RunStep();
            }
        }
    }
}



