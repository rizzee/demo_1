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
using System.Windows.Shapes;
using System.Configuration;
using System.Drawing;
using Size = System.Drawing.Size;
using Point = System.Drawing.Point;


namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        

        public Window1()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainWindow_Loaded);
            this.Closing += new System.ComponentModel.CancelEventHandler(MainWindow_Closing);
            if (statistica.fon  == 1)
            {
                var uri = new Uri(@"DayTheme.xaml", UriKind.Relative);

                ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;

                Application.Current.Resources.Clear(); Application.Current.Resources.MergedDictionaries.Add(resourceDict);
            }
            else
            {
                var uri = new Uri(@"NightTheme.xaml", UriKind.Relative);

                ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;

                Application.Current.Resources.Clear(); Application.Current.Resources.MergedDictionaries.Add(resourceDict);
            }

           

            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);

            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);

            time();


        }


        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();

        void time()
        {
            dispatcherTimer.Start();
        }

        public void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            Timer.sgame++;

            if (Timer.sgame > 59)
            {
                Timer.sgame = 0;
                Timer.mgame++;
            }

            if (Timer.mgame > 59)
            {
                Timer.mgame = 0;
                Timer.hgame++;
            }
        }


        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.WindowLocation != null)
            {
                double screenWidth = SystemParameters.PrimaryScreenWidth;
                double screenHeight = SystemParameters.PrimaryScreenHeight;
                double windowWidth = this.Width;
                double windowHeight = this.Height;

                this.Left = (screenWidth / 2) - (windowWidth / 2);
                this.Top = (screenHeight / 2) - (windowHeight / 2);
            }
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Properties.Settings.Default.WindowLocation = new Point(10, 20);
            Properties.Settings.Default.WindowSize = new Size(1519, 714);
            Properties.Settings.Default.Save();
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            statistica.Main++;
            dispatcherTimer.Stop();
            this.Owner.Show();
            this.Close();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2_Story_ Story = new Window2_Story_();
            statistica.Story++;
            Story.Owner = this;
            Story.Show();
            this.Hide();
        }

        private void dotaButton_Click(object sender, RoutedEventArgs e)
        {
            Window2_dota_ Dota = new Window2_dota_();
            statistica.Dota++;
            Dota.Owner = this;
            Dota.Show();
            this.Hide();
        }

        private void cs_Button_Click(object sender, RoutedEventArgs e)
        {
            Window2_CS_ CS = new Window2_CS_();
            statistica.Cs++;
            CS.Owner = this;
            CS.Show();
            this.Hide();
        }

        private void cen_Button_Click(object sender, RoutedEventArgs e)
        {
            Window2_censored_ cen = new Window2_censored_();
            statistica.Cen++;
            cen.Owner = this;
            cen.Show();
            this.Hide();
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.F1:
                    
                    HelpPage help = new HelpPage();
                    help.Owner = this;
                    help.Show();
                    break;

                case Key.D1:
                    Window2_Story_ Story = new Window2_Story_();
                    statistica.Story++;
                    Story.Owner = this;
                    Story.Show();
                    this.Hide();
                    break;

                case Key.D2:
                    Window2_dota_ Dota = new Window2_dota_();
                    statistica.Dota++;
                    Dota.Owner = this;
                    Dota.Show();
                    this.Hide();
                    break;

                case Key.D3:
                    Window2_CS_ CS = new Window2_CS_();
                    statistica.Cs++;
                    CS.Owner = this;
                    CS.Show();
                    this.Hide();
                    break;

                case Key.D4:
                    Window2_censored_ cen = new Window2_censored_();
                    statistica.Cen++;
                    cen.Owner = this;
                    cen.Show();
                    this.Hide();
                    break;

                case Key.Back:
                    statistica.Main++;
                    this.Owner.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
