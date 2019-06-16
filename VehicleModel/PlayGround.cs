using System;
using System.Collections.Generic;
using System.Text;

namespace Rover_ConsoleApp
{
    public class PlayGround
    {
        int xCoordinateMin;
        int xCoordinateMax;
        int yCoordinateMin;
        int yCoordinateMax;



        public PlayGround(int xCoordinateMin, int xCoordinateMax, int yCoordinateMin,
        int yCoordinateMax)
        {
            this.xCoordinateMin = xCoordinateMin;
            this.yCoordinateMin = yCoordinateMin;
            this.xCoordinateMax = xCoordinateMax;
            this.yCoordinateMin = yCoordinateMin;
        }
        public bool IsPointInside(int xCoordinate, int yCoordinate)
        {
            if (xCoordinate > xCoordinateMin && yCoordinate > yCoordinateMin)
            {
                if (xCoordinate < xCoordinateMax && yCoordinate < yCoordinateMax) 
                return true;
                else { return false; }
            }
           else { return false; } 
        }
    }
}


