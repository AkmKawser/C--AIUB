//Class Name: OFFSIDECOURSE.cs
//Namespace Name: Lab_Final_Library

using System;
namespace Lab_Final_Library
{
    public class OffSideCourse:Course
    {
        private string town;

        public OffSideCourse() { 
        
        }

        public string Town {
            set { this.town = value; }
            get { return this.town; }
        }

         public void Print() {
             Console.Write("OffSideCourse: Name=" + name + "; ");
             Console.Write("Teacher= "+tCher.Name+"; ");
             Console.Write("Topics=[");
            for (int i = 0; i < topics.Length; i++) {
                if (topics[i] != null)
                {
                    Console.Write("" + topics[i] + ",");
                }
                
            }
            Console.Write("] ");
            Console.Write("Town=" + this.town+"\n");
        
        }
    }
}
