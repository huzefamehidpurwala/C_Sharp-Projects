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

namespace WindowsFormsApp1_.netFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //=== --sql connection-- ===

            string connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\huzefa\Documents\Data_Test_Form1.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(connetionString);
            
            string query = $"SELECT Count(*) FROM Login WHERE USERNAME='{textBox1.Text}' AND PASSWORD='{textBox2.Text}'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString()  == "1")
            {
                this.Hide();
                Main Obj = new Main();
                Obj.Show();
            }
            else
            {
                //con.Open();
                MessageBox.Show("You are not authorized!", "Intruder Message");
                //con.Close();
            }

        }
    }
}
