using System;
using System.Windows;

namespace Trial_Learning_Project
{
    class Program
    {
        enum eCalculationType
        {
            Addition = 0,
            Substraction = 1,
            Multiplication = 2,
            Division = 3
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Student Obj = new Student();
            //Obj.SetName("Huzefa");

            //Obj.studentName = "Bashah";
            //Obj.

            //Console.WriteLine(Obj.studentName);
            //Console.ReadKey();

            // =====================================================
            
            // c# is a case sensitive lang. 

            // variables
            //string str = "Badshah";  /* variable name has letter, underscore or numbers. It can't start with no. */
            //bool bol = true;



            // flow control (if-else)

            int foodDeliverstatus = 0;
            if (foodDeliverstatus == 0)
            {
                Console.WriteLine("Food Delivered Succesfully!!");
            }
            else if(foodDeliverstatus == 1)
            {
                Console.WriteLine("Driver is on his way!!");
            }
            else
            {
                Console.WriteLine("Driver is not available!!");
            }

            // switch-case

            switch (foodDeliverstatus)
            {
                case 0: Console.WriteLine("Food Delivered Succesfully!!"); break;
                case 1: Console.WriteLine("Food Delivered Succesfully!!"); break;
                case 2: Console.WriteLine("Food Delivered Succesfully!!"); break;
                default: Console.WriteLine("Invalid Value Found!!"); break;
            }


            // for loop

            for(int i = 1; i <= 10; i++)
            {
                // statements here

                Console.WriteLine();
            }

            // while looop

            int totalcount = 10, count = 1;
            while (totalcount >= count)
            {
                
                count++;
            }

            // do while loop

            do
            {

            } while (totalcount >= count);

            // foreach loop

            int[] num = { 1, 2, 3, 4, 5, 6 };
            foreach(int temp in num)
            {
                // statements here
                //num.
            }

            // enum

            

        eCalculationType calculation;
        int choice = 0;

        calculation = (eCalculationType) choice; 
            if (calculation == eCalculationType.Addition)
            {

            }

            int[] num2 = { 1, 2, 3, 4, 5 };
            int a = num2[3];

            for (int i = 0; i < num2.Length; i++)
            {
                if (a == num2[i])
                {
                    Console.WriteLine("I got the value matched.");
                    break;
                }
            }
        }
    }
}
