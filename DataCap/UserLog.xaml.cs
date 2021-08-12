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
    /// Interaction logic for UserLog.xaml
    /// </summary>
    public partial class UserLog : Window
    {
        public UserLog()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            DataCap.Kinect_DatabaseDataSet1 kinect_DatabaseDataSet1 = ((DataCap.Kinect_DatabaseDataSet1)(this.FindResource("kinect_DatabaseDataSet1")));
            // Load data into the table LoginTable. You can modify this code as needed.
            DataCap.Kinect_DatabaseDataSet1TableAdapters.LoginTableTableAdapter kinect_DatabaseDataSet1LoginTableTableAdapter = new DataCap.Kinect_DatabaseDataSet1TableAdapters.LoginTableTableAdapter();
            kinect_DatabaseDataSet1LoginTableTableAdapter.Fill(kinect_DatabaseDataSet1.LoginTable);
            System.Windows.Data.CollectionViewSource loginTableViewSource1 = ((System.Windows.Data.CollectionViewSource)(this.FindResource("loginTableViewSource1")));
            loginTableViewSource1.View.MoveCurrentToFirst();
        }
    }
}
