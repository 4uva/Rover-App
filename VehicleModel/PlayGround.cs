using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleModel
{
    public class PlayGround
    {
        int xCoordinateMin;
        int xCoordinateMax;
        int yCoordinateMin;
        int yCoordinateMax;



        public PlayGround(int xCoordinateMin, int yCoordinateMin, int xCoordinateMax, int yCoordinateMax)
        {
            this.xCoordinateMin = xCoordinateMin;
            this.yCoordinateMin = yCoordinateMin;
            this.xCoordinateMax = xCoordinateMax;
            this.yCoordinateMax = yCoordinateMax;
        }

        public bool IsPointInside(int xCoordinate, int yCoordinate)
        {
            if (xCoordinate >= xCoordinateMin && yCoordinate >= yCoordinateMin)
            {
                if (xCoordinate <= xCoordinateMax && yCoordinate <= yCoordinateMax) 
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            } 
        }
    }
}


