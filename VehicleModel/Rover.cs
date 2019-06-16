using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleModel
{
    public class Rover : IRover
    {
        public Position Position { get; private set; }
        public RoverFacing Facing { get; private set; }
        private PlayGround playGround;

        public Rover(Position position, RoverFacing facing, PlayGround playGround)
        {
            Position = position;
            Facing = facing;
            this.playGround = playGround;
            if (!IsPositionGood(position))
                throw new ArgumentException("initial position outside border");
        }

        public void MoveForward()
        {
            int candidateX = Position.X;
            int candidateY = Position.Y;
            switch (Facing)
            {
                case RoverFacing.North:
                    candidateX--;
                    break;
                case RoverFacing.East:
                    candidateY++;
                    break;
                case RoverFacing.South:
                    candidateX++;
                    break;
                case RoverFacing.West:
                    candidateY--;
                    break;
            }
            Position candidatePosition = new Position(candidateX, candidateY);
            if (IsPositionGood(candidatePosition))
                Position = candidatePosition;
        }

        public void TurnLeft()
        {
            Facing = Facing == RoverFacing.North ?
                RoverFacing.West :
                (RoverFacing)((int)Facing - 1);
        }

        public void TurnRight()
        {
            Facing = Facing == RoverFacing.West ?
                RoverFacing.North :
                (RoverFacing)((int)Facing + 1);
        }

        bool IsPositionGood(Position position) => playGround.IsPointInside(position);
    }
}
