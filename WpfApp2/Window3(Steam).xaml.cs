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
    /// Логика взаимодействия для Window3_Steam_.xaml
    /// </summary>
    public partial class Window3_Steam_ : Window
    {
        
        public Window3_Steam_()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainWindow_Loaded);
            this.Closing += new System.ComponentModel.CancelEventHandler(MainWindow_Closing);

            if (statistica.fon == 1)
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            statistica.Main++;
            this.Owner.Show();
            this.Close();
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

                case Key.Right:
                    int nextTabIndex = MyTabControl.SelectedIndex + 1;
                    if (nextTabIndex >= MyTabControl.Items.Count)
                    {
                        nextTabIndex = 0;
                    }
                    MyTabControl.SelectedIndex = nextTabIndex;
                    e.Handled = true;
                    break;

                case Key.Left:
                    int previousTabIndex = MyTabControl.SelectedIndex - 1;
                    if (previousTabIndex < 0)
                    {
                        previousTabIndex = MyTabControl.Items.Count - 1;
                    }
                    MyTabControl.SelectedIndex = previousTabIndex;
                    e.Handled = true;
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

       
    }
}
