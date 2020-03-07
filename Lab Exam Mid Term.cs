//Class : Teacher.cs
//Namespace : Lab_Final_Library

using System;
namespace Lab_Final_Library
{
    public class Teacher
    {
        private string name;
        private Course[] courseList; //one to many asociation.

        public Teacher() { 
        
        }

        public Teacher(string name) {
            this.name = name;
        }

        public Teacher(string t,params Course[] val) {
            this.name = t;  
            this.courseList = val;  
           
        }

        public string Name {
            set { this.name = value; }
            get { return this.name; }
        }

        public void Print() { 
            Console.Write("Teacher: Name="+this.name+"; ");
            Console.Write(" Courses=[");
            for (int i = 0; i < courseList.Length; i++)
            {
                if (courseList[i] != null)
                {
                    Console.Write(""+courseList[i].Name+",");
                }
               
            }
            Console.Write("]");
        }
    }
}



//Class Name: OffsideCourse.cs
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


//Class Name: CampusCourse.cs
//Namespace Name: Lab_Final_Library

using System;
namespace Lab_Final_Library
{
    public class CampusCourse:Course
    {
        private string labNumber;

        public CampusCourse() { 
        
        }

        public string LabNumber
        {
            set { this.labNumber = value; }
            get { return this.labNumber; }
        }

        public void Print()
        {
            Console.Write("CampusCourse: Name="+name+";");
            Console.Write("Teacher= " + tCher.Name + ";");
            Console.Write("Topics=[");
            for (int i = 0; i < topics.Length; i++)
            {
                if (topics[i] != null)
                {
                    Console.Write("" + topics[i] + ",");
                }

            }
            Console.Write("] ");
            Console.Write("Lab=" + this.labNumber + "\n");

        }

    }
}


//Class Name: Course.cs 
//Namespace Name: Lab_Final_Library

using System;
namespace Lab_Final_Library
{
    public class Course
    {
        protected string name;
        protected Teacher tCher;   //one to one association
        protected string[] topics;  

        public Course() { 
         this.topics = new string[25];
        }

        public Course(string cName,Teacher t){
            this.name=cName;
            this.tCher=t;
        
        }

        public Teacher Teacher {
            set { this.tCher = value; }
            get { return this.tCher; }
        } 

        public string Name{
            set { this.name = value; }
            get {return this.name;}
        }



        public void AddTopic(string topic) { 
            for(int i=0;i < this.topics.Length;i++)
            {
                if(this.topics[i]==null)
                {
                    this.topics[i] = topic;
                    break;
                }
            }
        }


    }
}



//Class Name: Program.cs
//Namespace Name: C_Sharp_lab_Final35381

using System;
using Lab_Final_Library;

namespace C_Sharp_lab_Final35381
{
    class Program
    {
        static void Main(string[] args)
        {
            CampusCourse c = new CampusCourse();
            c.Name = "OOP2";
            c.Teacher = new Teacher("Victor Stany Rozario");
            c.LabNumber = "CL6";
            c.AddTopic("into DB");
            c.AddTopic("Property");
            c.AddTopic("PaRams");
            c.AddTopic("Arrray");
            c.Print();
            

            OffSideCourse s = new OffSideCourse();
            s.Name = "java";
            s.Teacher = new Teacher("Victor Stany Rozario");
            s.Town = "Dhaka";
            s.AddTopic("gui");
            s.AddTopic("AWT");
            s.AddTopic("Inheritance");
            s.Print();

            Teacher t = new Teacher("Ehsanul haque", c, s);
            t.Print();

            Console.ReadKey();
        }
    }
}
