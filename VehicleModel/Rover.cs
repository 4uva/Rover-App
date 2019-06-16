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
        private PlayGround playGround;

        public Rover(int roverPositionX, int roverPositionY, RoverFacing roverFacing, PlayGround playGround)
        {
            RoverPositionX = roverPositionX;
            RoverPositionY = roverPositionY;
            RoverFacing = roverFacing;
            this.playGround = playGround;
        }

        public void MoveForward()
        {
            int candidateXPosition = RoverPositionX;
            int candidateYPosition = RoverPositionY;
            switch (RoverFacing)
            {
                case RoverFacing.North:
                    candidateXPosition--;
                    break;
                case RoverFacing.East:
                    candidateYPosition++;
                    break;
                case RoverFacing.South:
                    candidateXPosition++;
                    break;
                case RoverFacing.West:
                    candidateYPosition--;
                    break;
            }
            if (playGround.IsPointInside(candidateXPosition, candidateYPosition))
            {
                RoverPositionX = candidateXPosition;
                RoverPositionY = candidateYPosition;
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
