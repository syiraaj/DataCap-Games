using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using System.Windows.Shapes;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Windows.Interop;
using System.Windows.Forms.Integration;
using System.Windows.Navigation;

namespace DataCap
{
    /// <summary>
    /// Interaction logic for Task1.xaml
    /// </summary>
    public partial class Task1 : Window
    {
        DispatcherTimer _timer;
        TimeSpan _time;
        
        public Task1(string MatrixVal, string UserVal, string Task)
        {
            InitializeComponent();

            textBlock1.Text = MatrixVal;
            textBlock2.Text = UserVal;
            textBlock3.Text = Task;

            _time = TimeSpan.FromSeconds(10);

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                textBlock.Text = _time.ToString("c");
                if (_time == TimeSpan.Zero) _timer.Stop();
                _time = _time.Add(TimeSpan.FromSeconds(-1));
            }, System.Windows.Application.Current.Dispatcher);

            _timer.Start();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ViewResult frm = new ViewResult(textBlock1.Text, textBlock2.Text, textBlock3.Text);
            frm.Show();
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}