using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Size = System.Drawing.Size;
using Point = System.Drawing.Point;
using System.Windows.Threading;


namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


       

        public static class AppSettings
        {
            public static BitmapImage BackgroundImage { get; set; } = (BitmapImage)Application.Current.Resources["Image1"];
        }
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainWindow_Loaded);
            this.Closing += new System.ComponentModel.CancelEventHandler(MainWindow_Closing);

            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);

            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);

            time();


            playButton.MouseEnter += PlayButton_MouseEnter;
            steamButton.MouseEnter += steamButton_MouseEnter;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var radioButton = (RadioButton)sender;
            if (radioButton.Content.ToString() == "Day_Mode")
            {
               var uri = new Uri(@"DayTheme.xaml", UriKind.Relative);

               ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;

               Application.Current.Resources.Clear(); Application.Current.Resources.MergedDictionaries.Add(resourceDict);
               
               statistica.fon++;
            }
            else if (radioButton.Content.ToString() == "Night_Mode")
            {
                var uri = new Uri(@"NightTheme.xaml", UriKind.Relative);

                ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;

                Application.Current.Resources.Clear(); Application.Current.Resources.MergedDictionaries.Add(resourceDict);

                statistica.fon--;
            }

            
        }


        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();

       

        void time()
        {
            dispatcherTimer.Start();
        }

        public void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            Timer.smain++;

            if (Timer.smain > 59)
            {
                Timer.smain = 0;
                Timer.mmain++;
            }

            if (Timer.mmain > 59)
            {
                Timer.mmain = 0;
                Timer.hmain++;
            }
        }


        private void Window_Deactivated(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Save();
            dispatcherTimer.Stop();

        }

        private void Window_Activated(object sender, EventArgs e)
        {
            time();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.WindowLocation != null)
            {
                double screenWidth = SystemParameters.PrimaryScreenWidth;
                double screenHeight = SystemParameters.PrimaryScreenHeight;
                double windowWidth = this.Width;
                double windowHeight = this.Height;
                statistica.Main++;
                this.Left = (screenWidth / 2) - (windowWidth / 2);
                this.Top = (screenHeight / 2) - (windowHeight / 2);
            }
           

        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Properties.Settings.Default.WindowLocation = new Point(10, 20);
            Properties.Settings.Default.WindowSize = new Size(1519, 450);
            Properties.Settings.Default.Save();

            MessageBoxResult result = MessageBox.Show("Вы уверены?", "ЭЭЭЭ КУДА", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }


        }

        


        private void PlayButton_MouseEnter(object sender, MouseEventArgs e)
        {
            mediaElement.Source = new Uri("Media/game_intro.mp4", UriKind.Relative);
            mediaElement.Play();
        }
        private void steamButton_MouseEnter(object sender, MouseEventArgs e)
        {
            mediaElement.Source = new Uri("Media/steam_into.mp4", UriKind.Relative);
            mediaElement.Play();
        }

        private void deviceButton_MouseEnter(object sender, MouseEventArgs e)
        {
            mediaElement.Source = new Uri("Media/device_intro.mp4", UriKind.RelativeOrAbsolute);
            mediaElement.Play();
        }

        private void companyButton_MouseEnter(object sender, MouseEventArgs e)
        {
            mediaElement.Source = new Uri("Media/comp_intro.mkv", UriKind.RelativeOrAbsolute);
            mediaElement.Play();
        }


        private void playButton_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Stop();
            Window1 Game = new Window1();
            statistica.Game++;
            dispatcherTimer.Stop();
            Game.Owner = this;
            Game.Show();
            this.Hide();
        }

        private void steamButton_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Stop();
            Window3_Steam_ Steam = new Window3_Steam_();
            statistica.Steam++;
            dispatcherTimer.Stop();
            Steam.Owner = this;
            Steam.Show();
            this.Hide();
        }

        private void deviceButton_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Stop();
            Window4_razrab_ Device = new Window4_razrab_();
            statistica.Device++;
            dispatcherTimer.Stop();
            Device.Owner = this;
            Device.Show();
            this.Hide();
        }

        private void companyButton_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Stop();
            Window5_corp_ corp = new Window5_corp_();
            statistica.Valve++;
            dispatcherTimer.Stop();
            corp.Owner = this;
            corp.Show();
            this.Hide();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
                switch (e.Key)
                {
                    case Key.F1:
                   
                    HelpPage help = new HelpPage();
                    

                    help.Show();
                    break;
                
                    case Key.D1:
                    mediaElement.Stop();
                    Window1 Game = new Window1();
                    statistica.Game++;
                    dispatcherTimer.Stop();
                    Game.Owner = this;
                    Game.Show();
                    this.Hide();
                    break;

                    case Key.D2:
                    mediaElement.Stop();
                    Window3_Steam_ Steam = new Window3_Steam_();
                    statistica.Steam++;
                    dispatcherTimer.Stop();
                    Steam.Owner = this;
                    Steam.Show();
                    this.Hide();
                    break;

                    case Key.D3:
                    mediaElement.Stop();
                    Window4_razrab_ Device = new Window4_razrab_();
                    statistica.Device++;
                    Device.Owner = this;
                    dispatcherTimer.Stop();
                    Device.Show();
                    this.Hide();
                    break;

                    case Key.D4:
                    mediaElement.Stop();
                    Window5_corp_ corp = new Window5_corp_();
                    statistica.Valve++;
                    dispatcherTimer.Stop();
                    corp.Owner = this;
                    corp.Show();
                    this.Hide();
                    break;

                case Key.Q:
                    mediaElement.Source = new Uri("Media/game_intro.mp4", UriKind.Relative);
                    mediaElement.Play();
                    break;

                case Key.W:
                    mediaElement.Source = new Uri("Media/steam_into.mp4", UriKind.Relative);
                    mediaElement.Play();
                    break;

                case Key.E:
                    mediaElement.Source = new Uri("Media/device_intro.mp4", UriKind.RelativeOrAbsolute);
                    mediaElement.Play();
                    break;

                case Key.R:
                    mediaElement.Source = new Uri("Media/comp_intro.mkv", UriKind.Relative);
                    mediaElement.Play();
                    break;

                default:
                        break;
                }
            

        }

        
    }
}
