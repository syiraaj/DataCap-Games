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
using System.Data.OleDb;

namespace DataCap
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        private OleDbConnection connection = new OleDbConnection();
        public Register()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Fairuz\Documents\Visual Studio 2015\Projects\DataCap\DataCap\Kinect Database.accdb;
Persist Security Info=False;";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO LoginTable ([PlayerID], [Player Name], [Age], [Programme], [Faculty]) VALUES ('" + textBox.Text + "', '" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "' )";

                command.ExecuteNonQuery();
                MessageBox.Show("Successfully registered.");
                connection.Close();

                MainWindow frm = new MainWindow();
                frm.Show();
                this.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show("Error" + es);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow frm = new MainWindow();
            frm.Show();
            this.Close();
        }
    }
}
