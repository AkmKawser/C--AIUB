/*PROGRAM-1:*/

using System;


namespace LabTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the ph level number of the aquarium");
            int ph = Convert.ToInt32(Console.ReadLine());

            if (ph == 7)
            {
                Console.WriteLine("The water is neutral");
            }

            else if (ph > 7)
            {
                Console.WriteLine("The water is alkaline");
            }

            else if (ph < 7)
            {
                Console.WriteLine("The water is acidic");
            }

            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.ReadKey();
        }
    }
}


/*PROGRAM-2:*/

Program.cs

using System;

namespace PracticeCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int month2;
            month2 = Convert.ToInt32(Console.ReadLine());
            Month month1 = new Month();
            if (month2 >= 1 && month2 <= 12)
            {
                Console.WriteLine(month1.ShowMonth(month2));
                Console.WriteLine(month1.ShowDays(month2));
            }
            else
                Console.WriteLine("Invalid Input");
        }
    }
}



AssignmentCShaprp.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentCSharp
{
    class Month
    {

        public static string month;
      

        public string ShowMonth(int monthNumber)
        {
            switch (monthNumber)
            {
                case 1:
                    month = "January";
                    break;
                case 2:
                    month = "February";
                    break;
                case 3:
                    month = "March";
                    break;
                case 4:
                    month = "April";
                    break;
                case 5:
                    month = "May";
                    break;
                case 6:
                    month = "June";
                    break;
                case 7:
                    month = "July";
                    break;
                case 8:
                    month = "August";
                    break;
                case 9:
                    month = "September";
                    break;
                case 10:
                    month = "October";
                    break;
                case 11:
                    month = "November";
                    break;
                case 12:
                    month = "December";
                    break;
            }
            return month;

        }

        public static string days;

        public string ShowDays(int monthNumber)
        {
            switch (monthNumber)
            {
                case 1:
                    days= "31";
                    break;

                case 2:
                    days= "28";
                    break;

                case 3:
                    days= "31";
                    break;

                case 4:
                    days= "30";
                    break;

                case 5:
                    days= "31";
                    break;

                case 6:
                    days= "31";
                    break;

                case 7:
                    days= "31";
                    break;

                case 8:
                    days= "31";
                    break;

                case 9:
                    days= "31";
                    break;

                case 10:
                    days= "31";
                    break;

                case 11:
                    days= "31";
                    break;

                case 12:
                    days= "31";
                    break;
            }

            return days;


        }



    }
}

/*Programg-3:*/

//Assembly-1: Program.cs
using ClassLibrary;
namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee e = new Employee();

            e.empNo = 1;
            e.name = "Kawser";
            e.dateOfbirth = "29/04/1994";
            e.dateOfHire = "1/1/2020";
            e.jobDesc = "Bla Bla";
            e.dept = "Software Enginner";
            e.Address = "Mirpur Dhaka";
            e.Mosal = 50000;
            e.ToString();
        }
    }
}



//Assembly-2: Employee.cs
using System;
namespace ClassLibrary
{
    public class Employee
    {
        public int empNo;
        public String name;
        public DateTime dateOfbirth;
        public String dateOfhire;
        public String jobDesc;
        public String dept;
        private int moSal;
        public int age;


        /*Parametarized Constructor */
        public Employee(int empNo, String name, DateTime dateOfbirth, String dateOfhire, String jobDesc, String dept)
        {
            this.empNo = empNo;
            this.name = name;
            this.dateOfbirth = dateOfbirth;
            this.dateOfhire = dateOfhire;
            this.jobDesc = jobDesc;
            this.dept = dept;
        }

        public int MoSal
        {
            set { this.moSal = value; }
            get { return this.moSal; }
        }
        
        /*Member Method*/
        public int Age(DateTime dateOfbirth)
        {
            
          //dateOfbirth =Convert.ToDateTime();
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfbirth.Year;
            if (dateOfbirth > today.AddYears(-age))
                age--;
            return age;          
        }
        public void ToString()
        {
            Console.WriteLine("Employee No:" + empNo);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Date Of Birth: " + dateOfbirth);
            Console.WriteLine("Date Of Hire: "+dateOfhire);
            Console.WriteLine("Job Description: {0}\nDepartment: {1}\nSalary: {2}", jobDesc, dept, moSal);
            Console.WriteLine("Age: " + age);
        }
        
    }
}
