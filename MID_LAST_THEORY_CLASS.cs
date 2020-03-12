//Upcasting,Downcasting,Method hiding,Method Overriding

using System;

namespace Virtual_Override
{
    public class Parent
    {
        virtual public void MyMethod()   // "Virtual" thakle next generation, ei method ke override korte parbe.
        {
            Console.WriteLine("Parent -> My Method");
        }
    }
    public class Child:Parent     //2nd genaration
    {
        override public void MyMethod()  //It Works as virtual for child2
        //sealed public void MyMethod()  //Stops override permission for child2 (next generation). ar class er age sealed use korle class er inheritance bondho kore dei.
        {
            Console.WriteLine("Child -> My Method");
        }
    }
    public class Child2:Child  // ThirdGenaration
    {
        new public void MyMethod()   //This is "Method Hiding". "new" er kaj holo parent er method ke hide kore child e notunvabe declare kora. 
        {
            Console.WriteLine("Child2 -> My Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Parent p = new Parent();
            //p.MyMethod();

           // Child c = new Child();
           // c.MyMethod();
             Child2 c2 = new Child2();
             c2.MyMethod();
            
          // Parent p1 = new Child();  
           //p1.MyMethod();
            

        }
    }
}

//If you want to stop override method, use "sealed" instead of "override"
//"Override" keyword works as override and virtual for its next generation.
