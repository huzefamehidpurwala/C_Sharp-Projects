using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Trial_Conn
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = "Server = BADSHAH1\\SQLEXPRESS; Database = huzefaLearning; Integrated Security = SSPI;";
            string insertQuery = "";//"INSERT INTO Student (StudentName, FatherName, Marks, Clearance) VALUES ('Rasika Joshi', 'Harshit Joshi', '85', 'PASS')";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand sql = new SqlCommand(insertQuery, conn);
            SqlDataAdapter sda = new SqlDataAdapter();

            sda.InsertCommand = new SqlCommand(insertQuery, conn);

            try
            {
                conn.Open();
                sda.InsertCommand.ExecuteNonQuery();
                Console.WriteLine("Inserted data Succesfully!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            sql.Dispose();
            conn.Close();
        }
    }
}
