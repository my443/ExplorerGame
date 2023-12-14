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
        SoccerBall Ball = new SoccerBall();

        public int ballLeft = 20;
        public int ballTop = 200;
        int horizontalDirection = 1;
        int verticalDirection = 1;


        public void moveBall()
        {
            //int nextMovePosition = ballLeft + (horizontalDirection * 20);

            //if (nextMovePosition > 400)
            //{
            //    horizontalDirection = -1;
            //    nextMovePosition = 400;
            //}
            //else if (nextMovePosition < 20)
            //{
            //    horizontalDirection = 1;
            //    nextMovePosition = 20;
            //}

            //ballLeft = nextMovePosition;

            Ball.moveBall();
            ballLeft = Ball.ballLeft;
            ballTop = Ball.ballTop;
            //return ballLeft;

        }

    }
}
