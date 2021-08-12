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

namespace DataCap
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            UserLog frm = new UserLog();
            frm.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            PlayResult frm = new PlayResult();
            frm.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow frm = new MainWindow();
            frm.Show();
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Play frm = new Play();
            frm.Show();
        }


        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Query frm = new Query();
            frm.Show();
        }
    }
}
