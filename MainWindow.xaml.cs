using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Timer
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly DispatcherTimer timer = new DispatcherTimer();

        private int sumS = 0; 
        private int sumM = 0;
        private int sumH = 0;       

        public MainWindow()
        {
            InitializeComponent();
            InitTimer();
        }

        private void InitTimer()
        {
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += TimerTick;
        }

        private void TimerTick(object sender, EventArgs e)
        {          
            if (sumS < 59)
            {
                lblTime.Content = Refresh(sumH, sumM, sumS++);
            }
            else
            {
                if (sumM < 59)
                {
                    lblTime.Content = Refresh(sumH, sumM++, 0);
                }
                else
                {
                    if (sumH <=22)
                    {
                        lblTime.Content = Refresh(sumH++, 0, 0);
                    }
                    else
                    {
                        lblTime.Content = Refresh(0, 0, 0);
                    }
                }
            }
        }

        private string Refresh(int sumH, int sumM, int sumS)
        {
            var h = sumH.ToString().Length < 2 ? "0" + sumH.ToString() : sumH.ToString();
            var m = sumM.ToString().Length < 2 ? "0" + sumM.ToString() : sumM.ToString();
            var s = sumS.ToString().Length < 2 ? "0" + sumS.ToString() : sumS.ToString();
            return h + ":" + m + ":" + s;
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            sumH = 0;
            sumM = 0;
            sumS = 0;

            lblTime.Content = Refresh(sumH, sumM, sumS);
            timer.Stop();

        }
    }
}
