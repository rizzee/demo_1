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
using Size = System.Drawing.Size;
using Point = System.Drawing.Point;
using System.IO;
using System.Windows.Threading;


namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для HelpPage.xaml
    /// </summary>
    public partial class HelpPage : Window
    {

        public HelpPage()
        {
            InitializeComponent();


            stat();

            this.Loaded += new RoutedEventHandler(MainWindow_Loaded);
            this.Closing += new System.ComponentModel.CancelEventHandler(MainWindow_Closing);
            string path1 = "instruct.txt";
            string lb1;
            using (System.IO.StreamReader reader = new StreamReader(path1))
            {
                lb1 = reader.ReadToEnd();
                lb.Content = lb1;
            }

            


        }

        string sm, mm, hm, sg, mg, hg, ss, ms, hs, sd, md, hd, scs, mcs, hcs, scen, mcen, hcen, sst, mst, hst, sdev, mdev, hdev, sco, mco, hco;
        
        void stat()
        {
            sm = Timer.smain.ToString("00");
            mm = Timer.mmain.ToString("00");
            hm = Timer.hmain.ToString("00");

            sg = Timer.sgame.ToString("00");
            mg = Timer.mgame.ToString("00");
            hg = Timer.hgame.ToString("00");

            ss = Timer.sstory.ToString("00");
            ms = Timer.mstory.ToString("00");
            hs = Timer.hstory.ToString("00");

            sd = Timer.sdota.ToString("00");
            md = Timer.mdota.ToString("00");
            hd = Timer.hdota.ToString("00");

            scs = Timer.scs.ToString("00");
            mcs = Timer.mcs.ToString("00");
            hcs = Timer.hcs.ToString("00");

            scen = Timer.scen.ToString("00");
            mcen = Timer.mcen.ToString("00");
            hcen = Timer.hcen.ToString("00");

            sst = Timer.ssteam.ToString("00");
            mst = Timer.msteam.ToString("00");
            hst = Timer.hsteam.ToString("00");

            sdev = Timer.sdevice.ToString("00");
            mdev = Timer.mdevice.ToString("00");
            hdev = Timer.hdevice.ToString("00");

            sco = Timer.scorp.ToString("00");
            mco = Timer.mcorp.ToString("00");
            hco = Timer.hcorp.ToString("00");
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

            lbm.Content = "Переход на главную был выполнен " + statistica.Main + " раз." + " " + hm + ":" + mm + ":" + sm; 
            lbg.Content = "Переход по вкладке Игры был выполнен " + statistica.Game + " раз." + " " + hg + ":" + mg + ":" + sg;
            lbs.Content = "Переход по вкладке Steam был выполнен " + statistica.Steam + " раз." + " " + hst + ":" + mst + ":" + sst;
            lbd.Content = "Переход по вкладке Девайсы был выполнен " + statistica.Device + " раз." + " " + hdev + ":" + mdev + ":" + sdev;
            lbv.Content = "Переход по вкладке Компания был выполнен " + statistica.Valve + " раз." + " " + hco + ":" + mco + ":" + sco;
            lbst.Content = "Переход по вкладке Сюжетные проекты был выполнен " + statistica.Story + " раз." + " " + hs + ":" + ms + ":" + ss;
            lbdt.Content = "Переход по вкладке Dota был выполнен " + statistica.Dota + " раз." + " " + hd + ":" + md + ":" + sd;
            lbcs.Content = "Переход по вкладке Counter_strike был выполнен " + statistica.Cs + " раз." + " " + hcs + ":" + mcs + ":" + scs;
            lbcen.Content = "Переход по вкладке Невышедшие был выполнен " + statistica.Cen + " раз." + " " + hcen + ":" + mcen + ":" + scen;

        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Properties.Settings.Default.WindowLocation = new Point(10, 20);
            Properties.Settings.Default.WindowSize = new Size(300, 300);
            Properties.Settings.Default.Save();
        }

    }
}
