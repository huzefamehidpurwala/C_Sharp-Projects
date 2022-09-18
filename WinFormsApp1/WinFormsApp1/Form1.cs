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
using System.Data.SqlTypes;

namespace WinFormsApp1
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
            //this.Hide();
            //Main Obj = new Main();
            //Obj.Show();

            //=== --sql connection-- ===

            //string connetionString;
            string connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\huzefa\Documents\Data_Test_Form1.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();
            MessageBox.Show("Connection Open!");
            con.Close();
        }
    }
}
