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
        public MainWindow()
        {
 
            this.InitializeComponent();
            _gameLoop = new GameLoop();
            MainCanvas.Loaded += MainCanvas_Loaded; 



            //_gameLoop.Initialize();


        }

        private void MainCanvas_Loaded(object sender, RoutedEventArgs e)
        {
            CompositionTarget.Rendering += GameLoopUpdate;
            //throw new NotImplementedException();
        }

        private void Load(object sender, NavigationEventArgs e)
        {
            CompositionTarget.Rendering += GameLoopUpdate;
            
        }


        private void GameLoopUpdate(object sender, object e)
        {
            _gameLoop.Update(sender, e);
        }

        //public void MainWindow_Load()
        //{
        //    _gameLoop = new GameLoop();
        //    MainWindow mainWindow = this;
        //    _gameLoop.MainWindow = mainWindow;

        //    _gameLoop.Render();
        //    Canvas.SetLeft(SoccerBall, 150);

        //}

        //private void moveBall() {
        //    int left = 1;
        //    int currentPosition = 10;

        //    while (true) { 
        //    if (left == 1)
        //    {
        //        currentPosition++;
        //    }
        //    else { 
        //        currentPosition--;
        //    }
        //    }

            //while (left == 1) {
            //    currentPosition++;
            //    if (currentPosition >= 500) {
            //        left = 0;
            //    }
            //    Canvas.SetLeft(SoccerBall, currentPosition);
            //}

            //while (left == 0)
            //{
            //    currentPosition++;
            //    if (currentPosition <= 10)
            //    {
            //        left = 1;
            //    }
            //    Canvas.SetLeft(SoccerBall, currentPosition);
            //}

        //}


        //private void myButton_Click(object sender, RoutedEventArgs e)
        //{
        //    myButton.Content = "Clicked";
        //}
    }
}
