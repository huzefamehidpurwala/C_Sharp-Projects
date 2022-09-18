using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_Learning_Project
{
    class Parents
    {
        public string city;  
        public string fatherName; //{ get; set; }
    }

    class Student : Parents
    {
        enum WeekDays
        {
            Monday=1, Tuesday, Wednesday
        }

        private string vstudentName = "huzefa";

        public string studentName 
        { 
            get { return vstudentName; }
            set
            {
                if (vstudentName == "Shabbir")
                {
                    vstudentName = value;
                }
            }
        }
        
        //public void SetName (string pName)
        //{
        //    studentName = pName;
        //}

        public string GetName()
        {
            return studentName + " son of " + fatherName;
        }

    }


}
