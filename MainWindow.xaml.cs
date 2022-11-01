using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace soufGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DispatcherTimer gameTimer = new DispatcherTimer();

        Random rnd = new Random();

        //List<ImageBrush> sprites = new List<ImageBrush>();
        ImageBrush playerSprite = new ImageBrush();


        public MainWindow()
        {
            InitializeComponent();

            gameCanvas.Focus();
            gameTimer.Tick += Update;
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);

            playerSprite.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/assets\adventurer-sprites.png"));
            AddPlayer();

        }

        private void Update(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void AddPlayer()
        {

            Rectangle rect = new Rectangle();
            var a = testRect;
            testRect.Fill = playerSprite;



            //gameCanvas.Children.Add(sprite);
            //Canvas.SetTop(sprite, 0);
            //Canvas.SetLeft(sprite, 0);
        }
    }
}
