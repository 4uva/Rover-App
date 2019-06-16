﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleModel
{
    public struct Position
    {
        public int X { get; }
        public int Y { get; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
