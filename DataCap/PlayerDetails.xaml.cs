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
using System.Windows.Threading;
using System.ComponentModel;

namespace DataCap
{
    /// <summary>
    /// Interaction logic for PlayerDetails.xaml
    /// </summary>
    public partial class PlayerDetails : Window
    {
        string TaskDone = "";
        public PlayerDetails(string MatrixVal, string UserVal)
        {
            InitializeComponent();

            textBlock.Text = MatrixVal;
            textBlock1.Text = UserVal;

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox.SelectedIndex >= 0)
                TaskDone = ((ComboBoxItem)comboBox.SelectedItem).Content.ToString();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Task1 frm = new Task1(textBlock.Text, textBlock1.Text, TaskDone);
            frm.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow frm = new MainWindow();
            frm.Show();
            this.Close();
        }
    }
}
