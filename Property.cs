//Instead of using MANUAL set get methods we can use property that gives built in SET GET METHOD FEATURES 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Person
    {
        private string name;
        private int age;
        private String dob;
        private String address;



        public String Name
        {

            set { this.name = value;}        
            get { return this.name;}

        }



        public int Age
        {
            set { this.age = value;}
            get { return this.age;}            
        }
      


        public String Dob
        {
            set { this.dob = value; }
            get { return this.dob;}

        }
       

        public String Address
        {
            set { this.address = value; }
            get { return this.address; }

        }

        public void ShowDetails()
        {
            System.Console.WriteLine("Student Name is: " + name);
            System.Console.WriteLine("Student Age is: " + age);
            System.Console.WriteLine("Student DOB is: " + dob);
            System.Console.WriteLine("Student Address is: " + address);

        }


        static void Main(string[] args)
        {
            Person p = new Person();

            p.Name = "Kawser";
            p.Age = 27;
            p.Dob = "29th aprial";
            p.Address = "Mirpur Dhaka";
            p.ShowDetails();

        }

    }
}
