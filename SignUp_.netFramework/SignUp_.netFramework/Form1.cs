using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SignUp_.netFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\huzefa\Documents\Data_Test_Form1.mdf;Integrated Security=True;Connect Timeout=30");

            bool check = radioButton1.Checked;
            string gender = "";
            if (check)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }

            string Lquery = $"INSERT INTO LOGIN VALUES ('{textBox2.Text}','{textBox3.Text}')";
            string Iquery = $"INSERT INTO Info VALUES ('{textBox1.Text}','{gender}')";

            //SqlDataAdapter Lsda = new SqlDataAdapter(Lquery,con);
            //SqlDataAdapter Isda = new SqlDataAdapter(Iquery,con);

            MessageBox.Show("Thank You!!!");
        }
    }
}
