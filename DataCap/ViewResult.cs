using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Interop;
using System.IO;
using System.Data.OleDb;

namespace DataCap
{
    public partial class ViewResult : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public ViewResult(string MatrixVal, string Task, string UserVal)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Fairuz\Documents\Visual Studio 2015\Projects\DataCap\DataCap\Kinect Database.accdb;
Persist Security Info=False;";

            textBox1.Text = MatrixVal;
            textBox3.Text = UserVal;
            textBox2.Text = Task;
        }

        private void ViewResult_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PlayerDetails frm = new PlayerDetails(textBox1.Text, textBox2.Text);
            frm.Show();
            this.Close();
        }

        private void Open()
        {
            try
            {
                OpenFileDialog opendl = new OpenFileDialog();
                opendl.InitialDirectory = "‪C:\\Users\\Fairuz\\Pictures\\Task";
                opendl.Filter = "JPEG|*.jpeg";

                if (opendl.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(opendl.FileName);
                    string ImagePath = opendl.FileName ;
                    textBox4.Text = ImagePath;
                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO PlayerResult ([PlayerID], [Task], [File Location]) VALUES ('" + textBox1.Text + "', '" + textBox3.Text + "','" + textBox4.Text + "' )";

                command.ExecuteNonQuery();
                MessageBox.Show("Successfully saved to database. Thank you for using DataCap.");
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
    }
}
