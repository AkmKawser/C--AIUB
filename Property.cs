//Instead of using MANUAL set get methods we can use property that gives built in SET GET METHOD FEATURES 

//Snap of Solution Explorer for the following code - https://ibb.co/HDvXLWM


/*1st assembly name -ConsoleApplication [Always এই নাম দিব কারন এইটা mainly এটা Console Application file] - এটা Startup Porject*/
//This assembly contains - Program.cs file 
using Mynamespace;  // adding namespace name [Is this called the reference?]
namespace Kawser
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person();

            p.Name = "Kawser";
            p.Age = 27;
            p.Dob = "29th April";
            p.Address = "Mirpur Dhaka";
            p.ShowDetails();
        }
    }
}




/*2nd assembly name - ClassLibrary [Always এই নাম দিব কারন এইটা mainly এটা Class Library file] */
//This assembly contains - Person.cs file
using System;

namespace Mynamespace
{
    
        public class Person
     {
            private string name;
            private int age;
            private String dob;
            private String address;



        public String Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public int Age
        {
            set { this.age = value; }
            get { return this.age; }
        }


        public String Dob
        {
            set { this.dob = value; }
            get { return this.dob; }
        }


        public String Address
        {
            set { this.address = value; }
            get { return this.address; }
        }


        public void ShowDetails()
        {
            Console.WriteLine("Student Name is: " + name);
            Console.WriteLine("Student Age is: " + age);
            Console.WriteLine("Student DOB is: " + dob);
            Console.WriteLine("Student Address is: " + address);
        }
    }
}
