using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleModel
{
    public interface IRover
    {
        Position Position { get; }
        RoverFacing Facing { get; }
        void MoveForward();
        void TurnLeft();
        void TurnRight();
    }
}
