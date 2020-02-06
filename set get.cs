using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
     public  class Person
    {
         private string name;
         private int age;
         private String dob;
         private String address;
         private String phone;


         public void SetName(String name)
         {

             this.name = name;
         }

         public String GetAge()
         {
             return this.name;

         }

         public void SetAge(int age)
         {
             this.age = age;
         }

         public int GetAge()
         {
             return this.age;
         }

         public void SetDob(String dob)
         {
             this.dob = dob;

         }

         public String GetDob()
         {
             return this.dob;

         }

         public void SetAddress(String address)
         {
             this.address = address;
         }

         public String GetAddress()
         {
             return this.address;
         }


         public void ShowDetails()
         {
               System.Console.WriteLine("Student Name is: " +name);
               System.Console.WriteLine("Student Name is: " + age);
               System.Console.WriteLine("Student Name is: " + dob);
               System.Console.WriteLine("Student Name is: " + address);
               System.Console.WriteLine("Student Name is: " + phone);
         }


         static void Main(string[] args)
         {
             Person p = new Person();
              
             p.SetName("Kawser");
             p.SetAge(27);
             p.SetDob("29th april");
             p.SetAddress("Mirpur Dhaka");
             p.ShowDetails();
           

         }

    }
}




