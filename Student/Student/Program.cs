using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonDesign;

namespace Student
{
    class Program
    {
        static SimpleDesign simpleDesign = new SimpleDesign();

        static void Main(string[] args)
        {
            string studentName = null, fatherName = null, motherName = null, clearence = null;
            string tablename = "Student", insertQuery = null;
            float marks;
            int stAge = 18;
            Msql msql = new Msql();


        start:
            Console.SetWindowSize(110, 40);
            simpleDesign.CenterBox("Welcome to the Software", '@', 10);

            Console.WriteLine("Press 1 to enter data or press any key to see previous data table!");
            Console.WriteLine();
            Console.Write("Or press 'q' or 'e' to exit: ");
            ConsoleKeyInfo check = Console.ReadKey();
            if (check.KeyChar == '1') goto enterdata;
            else if (check.KeyChar == 'q' || check.KeyChar == 'e' || check.KeyChar == 'Q' || check.KeyChar == 'E') Environment.Exit(0);
            else goto fetchdata;

            /*====================================================================================================================*/

            fetchdata:
            simpleDesign.CenterBox("Welcome to the Software", '@', 10);
            //Console.WriteLine("nothing here just now!!");

            msql.ReadData(tablename);

            //Console.WriteLine("Student's Name\tFather's Name\tMother's Name");
            //Console.WriteLine(studentName + "\t" + fatherName + "\t" + motherName);

            Console.WriteLine();
            Console.Write("Please enter any key to continue....");
            Console.ReadKey();
            goto start;

            /*====================================================================================================================*/

        enterdata:
            simpleDesign.CenterBox("Welcome to the Software", '@', 10);

            Console.Write("Enter the student's name: ");
            studentName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter the father's name: ");
            fatherName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter the mother's name: ");
            motherName = Console.ReadLine();

        inputmarks:
            Console.WriteLine();
            Console.Write("Enter student's marks: ");
            try
            {
                marks = float.Parse(Console.ReadLine());
            }
            catch
            {
                simpleDesign.ColorText("Please enter a numerical value!", 12, 1);
                goto inputmarks;
            }
            Console.WriteLine();

            //tablename = "Student";
            insertQuery = $"'{studentName}', '{fatherName}', '{motherName}', '{marks}', '{stAge}', '{clearence}'";
            bool dataCheck = msql.InsertData(tablename, insertQuery);
            if (dataCheck)
            {
                simpleDesign.ColorText("Data entered successfully!!!", 2);
                simpleDesign.CenterBox("Welcome to the Software", '@', 2);
            }
            Console.WriteLine();
            Console.Write("Please enter any key to continue....");
            Console.ReadKey();
            goto start;

            /*====================================================================================================================*/

            //Console.ReadKey();
        }
    }
}
