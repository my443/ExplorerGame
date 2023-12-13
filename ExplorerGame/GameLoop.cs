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

        public MainWindow Game { get; set; }
        public void Initialize(MainWindow CurrentGame)
        {
            Game = CurrentGame;            
            //Canvas.SetLeft(Game.Content.SoccerBall, 150);
        }

        public void Update(object sender, object e)
        {
            
            //CoreApplicationView coreView = CoreApplication.MainView;
            //CoreWindow coreWindow = coreView.CoreWindow;

            //if (coreWindow.Dispatcher != null)
            //{
            //    coreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            //    {
                    
            //        //
            //    });
            //}

        }

        public void Render()
        {

        }
    }
}
