using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorerGame
{
    public class Game
    {
        public int ballLeft = 20;
        int ballTop = 200;
        int horizontalDirection = 1;
        int verticalDirection = 1;

        public int moveBall()
        {
            int nextMovePosition = ballLeft + (horizontalDirection * 20);

            if (nextMovePosition > 400)
            {
                horizontalDirection = -1;
                nextMovePosition = 400;
            }
            else if (nextMovePosition < 20)
            {
                horizontalDirection = 1;
                nextMovePosition = 20;
            }

            ballLeft = nextMovePosition;

            return ballLeft;

        }

    }
}
