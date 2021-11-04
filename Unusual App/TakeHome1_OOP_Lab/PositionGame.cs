using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHome1_OOP_Lab
{
    class PositionGame
    {
        public int LEFT = -512, RIGHT = 512, BUTTOM = -512, TOP = 512;
        public int currX = 0, currY = 0;

        private PositionGame() { }

        private static PositionGame instance = null;
        public static PositionGame Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PositionGame();
                }
                return instance;
            }
        }

        public void BinarySearch2D(string button)
        {

            if (button == "North")
            {
                BUTTOM = currY;
            }
            else if (button == "South")
            {
                TOP = currY;
            }
            else if (button == "West")
            {
                RIGHT = currX;
            }
            else if (button == "East")
            {
                LEFT = currX;
            }
            else if (button == "NorthEast")
            {
                BUTTOM = currY;
                LEFT = currX;
            }
            else if (button == "NorthWest")
            {
                BUTTOM = currY;
                RIGHT = currX;
            }
            else if (button == "SouthEast")
            {
                TOP = currY;
                LEFT = currX;
            }
            else if (button == "SouthWest")
            {
                TOP = currY;
                RIGHT = currX;
            }

            currX = (LEFT + RIGHT) / 2;
            currY = (TOP + BUTTOM) / 2;
        }

        public void Reset()
        {
            LEFT = -512; RIGHT = 512; BUTTOM = -512; TOP = 512;
            currX = 0; currY = 0;
        }
    }
}