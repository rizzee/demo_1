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
using System.Windows.Resources;
using System.Configuration;
using System.Drawing;
using Size = System.Drawing.Size;
using Point = System.Drawing.Point;


namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Window2_Story_.xaml
    /// </summary>
    public partial class Window2_Story_ : Window
    {
       
        public Window2_Story_()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainWindow_Loaded);
            this.Closing += new System.ComponentModel.CancelEventHandler(MainWindow_Closing);
            list.Items.Add("Half-Life");
            list.Items.Add("Portal");
            list.Items.Add("Left 4 Dead");
            list.Items.Add("Самостоятельные дополнения");

            if (statistica.fon  == 1)
            {

                var uri = new Uri(@"DayTheme.xaml", UriKind.Relative);
                ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
                Application.Current.Resources.Clear();
                Application.Current.Resources.MergedDictionaries.Add(resourceDict);

            }
            else
            {
                var uri = new Uri(@"NightTheme.xaml", UriKind.Relative);
                ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
                Application.Current.Resources.Clear();
                Application.Current.Resources.MergedDictionaries.Add(resourceDict);
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


        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            statistica.Game++;
            this.Owner.Show();
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Close();
            Owner.Show();
        }

        

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (list.SelectedIndex == 0)
            {
                player.Source = new Uri("Media/HL1.mp3", UriKind.RelativeOrAbsolute);
                player.Play();
                BitmapImage image = new BitmapImage(new Uri("Media/hl_post.jpg", UriKind.Relative));

                imagebox.Source = image;
            }

            if (list.SelectedIndex == 1)
            {

                player.Source = new Uri("Media/portal.mp3", UriKind.RelativeOrAbsolute);
                player.Play();
                BitmapImage image = new BitmapImage(new Uri("Media/portal_post.jpg", UriKind.Relative));

                imagebox.Source = image;
            }

            if (list.SelectedIndex == 2)
            {
                player.Source = new Uri("Media/l4d.mp3", UriKind.RelativeOrAbsolute);
                player.Play();
                BitmapImage image = new BitmapImage(new Uri("Media/l4d_post.jpg", UriKind.Relative));

                imagebox.Source = image;
            }

            if (list.SelectedIndex == 3)
            {
                player.Source = new Uri("Media/dop.mp3", UriKind.RelativeOrAbsolute);
                player.Play();
                BitmapImage image = new BitmapImage(new Uri("Media/dop_post.jpg", UriKind.Relative));

                imagebox.Source = image;
            }
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

                case Key.Down:
                    list.IsDropDownOpen = true;
                    e.Handled = true;
                    break;

                case Key.D1:
                    { list.SelectedIndex = 0; }
                    break;
                    
                case Key.D2:
                     { list.SelectedIndex = 1; }
                    break;

                case Key.D3:
                     { list.SelectedIndex = 2; }
                    break;

                case Key.D4:
                    { list.SelectedIndex = 3; }
                    break;

                case Key.Back:
                    statistica.Game++;
                    this.Owner.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }
    }
}
