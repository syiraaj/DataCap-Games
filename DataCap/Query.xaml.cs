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
    /// Interaction logic for Query.xaml
    /// </summary>
    public partial class Query : Window
    {
        public Query()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            DataCap.Kinect_DatabaseDataSet kinect_DatabaseDataSet = ((DataCap.Kinect_DatabaseDataSet)(this.FindResource("kinect_DatabaseDataSet")));
            // Load data into the table LoginTable. You can modify this code as needed.
            DataCap.Kinect_DatabaseDataSetTableAdapters.LoginTableTableAdapter kinect_DatabaseDataSetLoginTableTableAdapter = new DataCap.Kinect_DatabaseDataSetTableAdapters.LoginTableTableAdapter();
            kinect_DatabaseDataSetLoginTableTableAdapter.Fill(kinect_DatabaseDataSet.LoginTable);
            System.Windows.Data.CollectionViewSource loginTableViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("loginTableViewSource")));
            loginTableViewSource.View.MoveCurrentToFirst();
            // Load data into the table PlayerResult. You can modify this code as needed.
            DataCap.Kinect_DatabaseDataSetTableAdapters.PlayerResultTableAdapter kinect_DatabaseDataSetPlayerResultTableAdapter = new DataCap.Kinect_DatabaseDataSetTableAdapters.PlayerResultTableAdapter();
            kinect_DatabaseDataSetPlayerResultTableAdapter.Fill(kinect_DatabaseDataSet.PlayerResult);
            System.Windows.Data.CollectionViewSource loginTablePlayerResultViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("loginTablePlayerResultViewSource")));
            loginTablePlayerResultViewSource.View.MoveCurrentToFirst();
        }
    }
}
