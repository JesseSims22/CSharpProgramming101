using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharpProgramming101
{
    class PassingObjectsMethods_Person
    {

        /*
               PassingObjectsMethods_Person person1 = new PassingObjectsMethods_Person("John", 20);
            Console.WriteLine("BEFORE: {0}, {1}", person1.Name, person1.Age);
            ChangePerson(person1);
            Console.WriteLine("AFTER: {0}, {1}", person1.Name, person1.Age);


          int[] myArray = new int[2];
            myArray[0] = 5;
            myArray[1] = 10;

            //creating object array
            PassingObjectsMethods_Person[] peopleArray = new PassingObjectsMethods_Person[2];
            peopleArray[0] = new PassingObjectsMethods_Person("Jesse", 25);
            peopleArray[1] = new PassingObjectsMethods_Person("John", 45);



            for(int i = 0; i < peopleArray.Length; i++)
            {
                Console.WriteLine("{0}, {1}", peopleArray[i].Name, peopleArray[i].Age);
            }

              public static void ChangePerson(PassingObjectsMethods_Person person1)
            {
                person1.Name = "Jeff";
                person1.Age = 45;
            }
         * */

        public static int Count;

        public PassingObjectsMethods_Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            Count++;

        }

        public string Name { get; set; }
        public int Age { get; set; }


    }
}
