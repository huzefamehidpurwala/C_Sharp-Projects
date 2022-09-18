using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Student
{
    public class Msql
    {
        static string connString = "Server = BADSHAH1\\SQLEXPRESS; Database = huzefaLearning; Integrated Security = SSPI;";
        SqlConnection conn = new SqlConnection(connString);
        string query = null;

        public void ReadData (string tablename)
        {
            string output = null;
            try
            {
                query = $"SELECT * FROM {tablename}";
                conn.Open();
                SqlCommand sql = new SqlCommand(query, conn);
                SqlDataReader dataReader = sql.ExecuteReader();
                for (int i = 0; dataReader.Read(); i++)
                {
                    output = output + dataReader.GetValue(i) + "\t";
                    if ()
                    //output = output + dataReader.GetValue(0) + "-" + dataReader.GetValue(1) + "-" + dataReader.GetValue(2) + "-" + dataReader.GetValue(3) + "-" + dataReader.GetValue(4) + "-" + dataReader.GetValue(5) + "-" + dataReader.GetValue(6) + "\n"; 
                }
                Console.Write(output);

                dataReader.Close();
                sql.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
                Console.WriteLine("Failed to pass the data through the database!");
                Console.WriteLine();
                Console.Write("Please enter any key to continue....");
                Console.ReadKey();
                conn.Close();
            }

        }
        
        public bool InsertData (string tablename, string str1, string str2 = null)
        {
            if (str2 != null) query = $"INSERT INTO {tablename} ({str2}) VALUES ({str1})";
            else query = $"INSERT INTO {tablename} VALUES ({str1})";
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter();

            sda.InsertCommand = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                sda.InsertCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
                Console.WriteLine("Failed to pass the data through the database!");
                //Console.WriteLine();
                //Console.Write("Please enter any key to continue....");
                //Console.ReadKey();
                sql.Dispose();
                conn.Close();
            }

            sql.Dispose();
            conn.Close();
            return false;
        }
    }
}
