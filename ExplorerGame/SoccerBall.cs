using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorerGame
{
    internal class SoccerBall
    {
        public int ballLeft = 20;
        public int ballTop = 200;
        int horizontalDirection = 1;
        int verticalDirection = 1;

        private int top = 0;
        private int bottom = 400;        
        private int right = 0;
        private int left = 827;

        public void moveBall()
        {
            int nextHorizontalMovePosition = ballLeft + (horizontalDirection * 20);
            int nextVerticalMovePosition = ballTop + (verticalDirection * 16);

            if (nextHorizontalMovePosition > left)
            {
                horizontalDirection = -1;
                nextHorizontalMovePosition = left;
            }
            else if (nextHorizontalMovePosition < right)
            {
                horizontalDirection = 1;
                nextHorizontalMovePosition = right;
            }

            if (nextVerticalMovePosition > bottom)
            {
                verticalDirection = -1;
                nextVerticalMovePosition = bottom;
            }
            else if (nextVerticalMovePosition < top)
            {
                verticalDirection = 1;
                nextVerticalMovePosition = top;
            }

            ballLeft = nextHorizontalMovePosition;
            ballTop = nextVerticalMovePosition;


            //return ballLeft;

        }
    }
}
