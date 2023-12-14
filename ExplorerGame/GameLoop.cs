using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace ExplorerGame
{
    public class GameLoop
    {
        public bool Running { get; private set; }
        public MainWindow _myGame { get; set; }

        /// <summary>
        /// Load Game into GameLoop
        /// </summary>
        public void Load(MainWindow gameObj)
        {
            _myGame = gameObj;
        }
        public async void Start()
        {
   
            // Set gameloop state
            Running = true;

            // Set previous game time
            DateTime _previousGameTime = DateTime.Now;

            while (Running)
            {
                // Calculate the time elapsed since the last game loop cycle
                TimeSpan GameTime = DateTime.Now - _previousGameTime;
                // Update the current previous game time
                _previousGameTime = _previousGameTime + GameTime;
                // Update the game
                _myGame.moveBall();             
                // Update Game at 60fps
                await Task.Delay(8);
            }
        }

        public void Update(object sender, object e)
        {
            //CoreApplicationView coreView = CoreApplication.MainView;
            //CoreWindow coreWindow = coreView.CoreWindow;

            ////CoreApplicationView coreView = CoreApplication.MainView;
            ////CoreWindow coreWindow = coreView.CoreWindow;

            //if (coreWindow.Dispatcher != null)
            //{
            //    coreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            //    {
            //        //Canvas.SetLeft(sender.SoccerBall, 800);
            //    });
            //}

        }

        public void Render()
        {

        }
    }
}
