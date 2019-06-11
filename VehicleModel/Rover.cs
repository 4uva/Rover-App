using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleModel
{
    public class Rover
    {
        public int RoverPositionX { get; private set; }
        public int RoverPositionY { get; private set; }
        public RoverFacing RoverFacing { get; private set; }

        public Rover(int roverPositionX, int roverPositionY, RoverFacing roverFacing)
        {
            RoverPositionX = roverPositionX;
            RoverPositionY = roverPositionY;
            RoverFacing = roverFacing;
        }

        public void MoveForward()
        {
            switch (RoverFacing)
            {
                case RoverFacing.North:
                    RoverPositionX++;
                    break;
                case RoverFacing.East:
                    RoverPositionY++;
                    break;
                case RoverFacing.South:
                    RoverPositionX--;
                    break;
                case RoverFacing.West:
                    RoverPositionY--;
                    break;
            }
        }

        public void TurnLeft()
        {
            RoverFacing = RoverFacing == RoverFacing.North ?
                RoverFacing.West :
                (RoverFacing)((int)RoverFacing - 1);
        }
        public void TurnRight()
        {
            RoverFacing = RoverFacing == RoverFacing.West ?
                RoverFacing.North :
                (RoverFacing)((int)RoverFacing + 1);
        }
    }
}
