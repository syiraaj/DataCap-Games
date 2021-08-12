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
    /// Interaction logic for PlayResult.xaml
    /// </summary>
    public partial class PlayResult : Window
    {
        public PlayResult()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            DataCap.Kinect_DatabaseDataSet2 kinect_DatabaseDataSet2 = ((DataCap.Kinect_DatabaseDataSet2)(this.FindResource("kinect_DatabaseDataSet2")));
            // Load data into the table PlayerResult. You can modify this code as needed.
            DataCap.Kinect_DatabaseDataSet2TableAdapters.PlayerResultTableAdapter kinect_DatabaseDataSet2PlayerResultTableAdapter = new DataCap.Kinect_DatabaseDataSet2TableAdapters.PlayerResultTableAdapter();
            kinect_DatabaseDataSet2PlayerResultTableAdapter.Fill(kinect_DatabaseDataSet2.PlayerResult);
            System.Windows.Data.CollectionViewSource playerResultViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("playerResultViewSource")));
            playerResultViewSource.View.MoveCurrentToFirst();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
