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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.OleDb;
using System.Windows.Forms.Integration;

namespace DataCap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private OleDbConnection connect = new OleDbConnection();
        public MainWindow()
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Fairuz\Documents\Visual Studio 2015\Projects\DataCap\DataCap\Kinect Database.accdb;
Persist Security Info=False;";
        }

        private void MainWindow_Load (object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Register frm = new Register();
            frm.Show();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            connect.Open();

            OleDbCommand command = new OleDbCommand();
            command.Connection = connect;

            command.CommandText = "SELECT * FROM LoginTable WHERE [PlayerID] = '" + textBox.Text + "' and [Player Name] = '" + textBox1.Text + "' ";
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;

            while (reader.Read())
            {
                count++;
            }

            if (count == 1)
            {
                if (textBox.Text == "3134009781" && textBox1.Text == "Syahirah")
                {
                    MessageBox.Show("Login Successful. Welcome, " + textBox1.Text + ".");

                    Admin frm = new Admin();
                    frm.Show();
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Login Successful. Welcome, " + textBox1.Text + ".");

                    PlayerDetails frm = new PlayerDetails(textBox.Text, textBox1.Text);
                    frm.Show();
                    Play frm1 = new Play();
                    frm1.Show();
                    Capture frm2 = new Capture();
                    frm2.Show();
                 
                    this.Close();
                }
            }

            else if (count > 1)
            {
                MessageBox.Show("Duplicate Username and Matrix Number.");
            }

            else
            {
                MessageBox.Show("You need to register in order to play.");
                Register frm = new Register();
                frm.Show();
                this.Close();
            }
            connect.Close(); 
        }
    }
}
