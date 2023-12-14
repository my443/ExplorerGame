using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ExplorerGame
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 

    public sealed partial class MainWindow : Window
    {
        GameLoop _gameLoop;
        Game Game = new Game();

        public MainWindow()
        {

            this.InitializeComponent();
            _gameLoop = new GameLoop();
            _gameLoop.Load(Game);
            _gameLoop.Start();
            CompositionTarget.Rendering += GameLoopUpdate;                  // This subscribes to the CompositionTarget.Rendering event.
                                                                            // Called once per frame refresh (usually 60fps)
                                                                            // https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.compositiontarget.rendering?view=windowsdesktop-8.0
        }

        private void GameLoopUpdate(object sender, object e)
        {
            Canvas.SetLeft(SoccerBall, Game.ballLeft);
            Canvas.SetTop(SoccerBall, Game.ballTop);
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            myButton.Content = "Clicked. Ball at:" + Game.ballLeft.ToString();
            Canvas.SetLeft(SoccerBall, Game.ballLeft);
        }
    }
}
