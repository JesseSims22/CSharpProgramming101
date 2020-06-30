using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProgramming101
{
    class Student
    {
        //Class is a blueprint.
        //Constructor is the required fields/param to be able to use the class
        //Constructor has no return type and the name is the name of the class

        //Create fields/instant variables
        //These are private variables because I only want these to be edited during the constructor call

        /* if they are public you can update this way:
          //create instant of Class Students - instantiation 
                //Just one veresion of the blueprint
                Student c_Student = new Student("Bob", "denver", 25, 77.2);                
                Student c_Student2 = new Student("Jim","denver", 77, 98.6);
                Student c_Student3 = new Student("Joe","denver", 36, 86);
                c_Student.SayHello();
                c_Student2.SayHello();
                c_Student3.SayHello();

                Student c_Student4 = new Student("Frank", 25);

                Student c_Student5 = new Student("Tom");
                c_Student5.SayHello();

                Console.WriteLine(c_Student.GetName());

                c_Student.SetName("");
                Console.WriteLine(c_Student.GetName());

                c_Student.LastName = "denverset";
                Console.WriteLine(c_Student.LastName);
        */
        private string s_Name;
    private int i_Age;
    private double d_FinalGrade;

    //Auto-Implemented Property
    //used to have get/set without having to type the get and set without private data
    public string LastName { get; set; }
        //public string LastName { get; private set; }
        //using the private keyword we have protected the data so that it can only be returned but not set. 

        //Constructor - required information for the class
        public Student(string name, string lastName, int age, double finalgrade)
    {
            /*
             * create instant of class with constructor values
             *     
             Student c_Student = new Student("Bob",25, 77.2);    
            c_Student.SayHello();
            Student c_Student2 = new Student("Jim", 77, 98.6);
            Student c_Student3 = new Student("Joe", 36, 86);
            */

            //this. is opitional in this example but could be used if the variable names were the same
            this.s_Name = name;
            this.i_Age = age;
            this.LastName = lastName;
            this.d_FinalGrade = finalgrade;

    }

    public Student(string s_Name, int i_Age)
    {
            //overload constructor to have version without final grade
            this.s_Name = s_Name;
            this.i_Age = i_Age;
    }

     public Student(string s_Name) :this(s_Name,"",0,0)
     {
         //overload constructor to have version without final grade
         //REmove code duplicate by having this constructor call another constructor
        
     }

     public void SayHello()
    {
        Console.WriteLine("Hello from {0}", s_Name);
    }

     public string GetName()
     {
             //Get and Sets can be used to control what can be returned and what can be updated.
             //Get and Sets should be used instead of using global/public values. 
            //Can add constraints here to only return based on logic/conditions.

            
            return s_Name;
     }

    public void SetName(string newName)
     {
            if (newName !="")
            {
                s_Name = newName;
            }
            
     }

        public void CSharpProperties()
        {
            //Properties are a C# specific way of doing Get/Set. Only in C#
            /*
             * Best practice is to use Uppercase for PUblic "Name" and lowercase for private data type s_Name. (aka name)
             * Usage of below property when calling class
             * Student1.Name = "Bob";
            
            public string Name
            get
            {
                   return s_Name;
            }
            set
            {
                 if (value !="") //switch out variable to "value"
                {
                    s_Name = value; //switch to value instead of variable
                }
            }

            */
        }

    }
}
