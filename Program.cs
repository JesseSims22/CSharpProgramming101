using System;
using System.Linq;

namespace CSharpProgramming101
{
    class Program
    {
        static void Main(string[] args)
        {

            HomeServiceJobs job1 = new HomeServiceJobs("Painting", 2, 52.25);

            Console.WriteLine(job1.TotalFee);
        }

      

        static void Basics ()
        {
            /* Declare/Create and Initialize the Variables with assignment operators (=) */

            int IntVar = 1;             //Integer whole number, no decimals
            double DoubleVar = 1.1;     //Decimal
            string StringVar = "test";  //Group of Char's
            bool BoolVar = false;       //True/False        
            char CharVar = 'A';         //Holds one value          

            /* declaring multiple variables on same line*/
            int IntVar1 = 5, IntVar2 = 6;

            //Write out to console as a new line
            Console.WriteLine(IntVar);

            //Write out to console as same line
            Console.Write(StringVar);
            Console.Write(StringVar);

            Console.WriteLine("");

            //Write out the value in a string using a placeholder.
            Console.WriteLine("The value of IntVar is {0}", IntVar);
            //Same result but using Concat method
            Console.WriteLine("The value of IntVar is " + IntVar);


            //Write out the value in a string using a placeholder.
            Console.WriteLine("The value of IntVar is {0} and the value of my DoubleVar is {1}", IntVar, DoubleVar);
            //Same result but using Concat method
            Console.WriteLine("The value of IntVar is " + IntVar + " and the value of my DoubleVar is " + DoubleVar);
        }
        static void DivisionWithDataTypes ()
        {
            //Integer division instead of decimal
            double aDoubleVar = 45 / 2;
            double aDoubleVarCorrect = 45.0 / 2;
            Console.WriteLine("Integer division removes remainder...45 is divided by 2 with an answer of {0}", aDoubleVar);
            Console.WriteLine("Decimal division includes remainder...45 is divided by 2 with an answer of {0}", aDoubleVarCorrect);


            //Modular - get the remainder
            double d_mod = 45 % 2;
            Console.WriteLine(d_mod);
        }
        static void RandomNumberComparision()
        {
            /*Loop that accepts a number between 1 and 10 and compare it to 
            * a random number           
            */
            int i_Response;
            int i_MinRandom = 1;
            int i_MaxRandom = 11;
            int i_GuessAmt = 0;
            Random r_RandomGen = new Random();
            int i_Random = r_RandomGen.Next(i_MinRandom, i_MaxRandom);

            do
            {
                Console.WriteLine("Guess a number between 1 and 10");
                i_Response = Convert.ToInt32(Console.ReadLine());

                if (i_Response < i_MinRandom || i_Response > i_MaxRandom)
                {
                    Console.WriteLine("Reponse is outside the range, please enter a number between {0} and {1}", i_MinRandom, i_MaxRandom - 1);
                }
                else if (i_Response > i_Random)
                {
                    Console.WriteLine("Response is too high, guess lower number");
                }
                else if (i_Response < i_Random)
                {
                    Console.WriteLine("Response is too low, guess higher number");
                }
                else
                {
                    Console.WriteLine("You guess the correct number!!");

                }

                //Increment the number of guess
                i_GuessAmt += 1;

            } while (i_Response != i_Random);

            Console.WriteLine("It took you {0} guesses to guess correctly", i_GuessAmt);
        }
        static void SearchingArrays()
        {
            /*Arrays      
             * 
             * Element - separate integer/object/strings in array
             * Index - position in the array
             */

            int[] ay_IntArray = new int[10];

            ay_IntArray[0] = 1;
            ay_IntArray[1] = 2;

            //Same ways with shorthand
            int[] ay_DefArray = new int[3] { 5, 6, 7 };
            int[] ay_DefArraySh0 = new int[] { 5, 6, 7 };
            int[] ay_DefArraySh1 = { 5, 6, 7 };

            string[] ay_StringArray = { "John", "Jesse", "Sandy" };

            //For Loop to print names
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(ay_StringArray[i]);
            }

            //Foreach loop to print names
            foreach (string s_names in ay_StringArray)
            {
                Console.WriteLine(s_names);
            }

            //For Loop to print names but skips middle name, can't do this with ForEach
            for (int i = 0; i < 3; i += 2)
            {
                Console.WriteLine(ay_StringArray[i]);
            }



            string s_Reponse;
            int i_ArrayIndex = 0;
            bool b_check = false;
            int i_Age = 0;

            int[] ay_AgeArray = { 98, 25, 46 };


            //Ask for Name, assign to Response variable
            Console.WriteLine("Enter name to search");
            s_Reponse = Console.ReadLine();


            for (int i = 0; i < ay_StringArray.Length; i++)
            {
                if (s_Reponse == ay_StringArray[i])
                {
                    b_check = true;
                    i_ArrayIndex = i;

                    //once found, seet age to age variable
                    i_Age = ay_AgeArray[i];

                    //Once found, breakout of loop
                    break;
                }
            }

            if (b_check == false)
            {
                Console.WriteLine("Name not found in Array");
            }
            else
                Console.WriteLine("The name {0} was found in the Array at Index Position {1} and their age is {2}", s_Reponse, i_ArrayIndex, i_Age);
        }
        static void CommonArrayFunctions()
        {
            //Using Methods to search Array - Binary Search - Must be sorted

            //If orders are in numbers, using binary search will work.

            int[] a_IntArrayMethod = { 5, 10, 15, 20, 25, 30, 40, 70 };

            Console.WriteLine("Enter number to check if it exists");
            int i_MethodResponse = int.Parse(Console.ReadLine());

            int i_MethodResponseAnswer = Array.BinarySearch(a_IntArrayMethod, i_MethodResponse);

            if (i_MethodResponseAnswer < 0)
            {
                Console.WriteLine("The number was not found");
            }
            else
            {
                Console.WriteLine("The number was found in array position {0}", i_MethodResponseAnswer);
            }

            //Sorting the array
            int[] a_IntArraySort = { 40, 30, 5, 10, 15, 20, 25, 70 };
            //Print out unsorted array
            Console.WriteLine("Unsorted Array....");
            for (int i = 0; i < a_IntArraySort.Length; i++)
            {
                Console.WriteLine(a_IntArraySort[i]);
            }

            Array.Sort(a_IntArraySort);

            Console.WriteLine("Sorted Array....");
            //Print out sorted array
            for (int i = 0; i < a_IntArraySort.Length; i++)
            {
                Console.WriteLine(a_IntArraySort[i]);
            }

            Array.Reverse(a_IntArraySort);

            Console.WriteLine("Reversed Array....");
            //Print out Reversed array
            for (int i = 0; i < a_IntArraySort.Length; i++)
            {
                Console.WriteLine(a_IntArraySort[i]);
            }
        }
        static void OperatorsAndEscape ()
        {
            //Arithmetic Operators
            /* 
            Shorthands
            +=
            -=
            *=
            x++
            */

            /*Operators
           >
           >=
           <
           <=
           !=
           ==         
           NOT (!myBool) - ! does opposite
           Inline Condition IF - (condition) ? true | false
            */

            /*Escape Characters
            \
            \n - new line
            \t - tab

            char escapeChar = '\'';

            */

        }
        static void MultiDimArrays()
        {
            /*Rectangler Array - Each row has the same amount of columns
                    5 6 7
                    8 9 5
                    1 2 3

            int[,] - comma represents a new dimension. 2 columns are 3 dimensions,etc


            */

            int[,] a_Array = new int[3, 4]; //[<rows>, <columns>]

            //3 rows with 4 columns
            //****
            //****
            //****

            //populate first row
            a_Array[0, 0] = 5;
            a_Array[0, 1] = 6;
            a_Array[0, 2] = 7;
            a_Array[0, 3] = 8;
            //Populate second row
            a_Array[1, 0] = 5;
            a_Array[1, 1] = 6;
            a_Array[1, 2] = 7;
            a_Array[1, 3] = 8;
            //Populate third row
            a_Array[2, 0] = 5;
            a_Array[2, 1] = 6;
            a_Array[2, 2] = 7;
            a_Array[2, 3] = 8;

            //print out contents of multi-dim array
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(a_Array[i, j]);
                }
                Console.WriteLine();
            }


            //Shorthand way to populate array from beginning, same as above
            int[,] a_ShortHandArray = { { 5, 6, 7, 8 }, 
                                        { 5, 6, 7, 8 }, 
                                        { 5, 6, 7, 8 } };


            //For loop to populate numbers in multi-dimensional array

            int[,] a_ForLoopArray = new int[3, 4];



            /*Jagged Array - every row has another array "Array of Arrays"
             * 
             *      5 6 7
                    8 9 5 9
                    1 2 3

            [<rows>][<columns>]
            don't know the number of columns at this point, just define the rows
             */

            int[][] a_JaggedArray = new int[3][];

            //First row/array in this Array has 4 columns, it's an array of 4.
            a_JaggedArray[0] = new int[4]; // a_JaggedArray[0] = new int[4] {5,6,7,8};

            //Second row/array in this Array has 10 columns, it's an array of 10.
            a_JaggedArray[1] = new int[10]; //a_JaggedArray[0] = new int[10] { 5, 6, 7, 8,9,10, 11,12,13,14 };
            //Third row/array in this Array has 10 columns, it's an array of 10.
            a_JaggedArray[2] = new int[2];


            int[][] a_JaggedArrayDef = new int[3][];
            a_JaggedArrayDef[0] = new int[4] { 5, 6, 7, 8 };
            a_JaggedArrayDef[1] = new int[10] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            a_JaggedArrayDef[2] = new int[6] { 5, 6, 7, 8,9,10};

            Console.WriteLine(a_JaggedArrayDef[1].GetLength(0));

            //reading out of mult-dimensional jagged array
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < a_JaggedArrayDef[i].Length; j++)
                {
                    Console.Write(a_JaggedArrayDef[i][j] + " ");
                }
                Console.WriteLine();
            }


        }
        static void ZipCodeSearchArray()
        {
            //Array with 10 zip codes
            int[] a_ZipCodeArray = { 40342, 42301, 42303, 40268, 95231, 45761, 13247, 12345, 78945, 45612 };
            int i_InputZip;
            int i_SearchResult;

            Console.WriteLine("Enter a zip code to search...");
            i_InputZip = Int32.Parse(Console.ReadLine());

            Array.Sort(a_ZipCodeArray);

            i_SearchResult = Array.BinarySearch(a_ZipCodeArray, i_InputZip);

            if (i_SearchResult < 0)
            {
                Console.WriteLine("Zip code was not found....");
            }
            else
                Console.WriteLine("Zip code was found at position {0} in the array", i_SearchResult);
            
            //Print out values in array, sorted
            for(int i = 0; i<a_ZipCodeArray.Length; i++)
            {
                Console.WriteLine(a_ZipCodeArray[i]);                
            }

            
            //Using a loop search
            Console.WriteLine("Enter a zip code to search using Loop...");
            i_InputZip = Int32.Parse(Console.ReadLine());
            bool b_Check = false;

            for(int i = 0; i< a_ZipCodeArray.Length; i++)
            {
                if (i_InputZip == a_ZipCodeArray[i])
                {
                    b_Check = true;
                    break;
                    
                }
            }


            if (b_Check == true)
            {
                Console.WriteLine("We do ship to this zip code");
            }
            else
                Console.WriteLine("Zip code was not found....");


        }
        static void ParallelArray()
        {
            
    
            
            int i_NumberOfStudents = 0;

            Console.WriteLine("Enter the number of students in the class...");
            i_NumberOfStudents = Int32.Parse(Console.ReadLine());

            //Build arrays with the number of students
            string[] a_Students = new string[i_NumberOfStudents];
            double[] a_Grades = new double[i_NumberOfStudents];
            double i_MaxGrade = 0;
            double i_AvgGrade = 0;

            for (int i=0; i< a_Students.Length; i++)
            {
                Console.WriteLine("Enter #{0} students name...", i+1);
                a_Students[i] = Console.ReadLine();

                Console.WriteLine("Enter the students final grade...");
                a_Grades[i] = Double.Parse(Console.ReadLine());
            }

    

            Console.WriteLine("The highest grade in class is {0}", a_Grades.Max());
            Console.WriteLine("The average grade in the class was {0}", a_Grades.Average());


            for (int i = 0; i < a_Students.Length; i++)
            {
                Console.WriteLine(a_Students[i] + " Final Grade:" + a_Grades[i]);
           
            }


        }
        public static void Methods_AddNoReturn(int i_num1, int i_num2)
        {
            //PUblic - anyone can use it across classes
            //Private - can only be used within class
            //void means it doesn't return anything
            //Pass by Value - just sending in the value not the actual reference/variables.
            //If it's an int/double/bool,etc (structs) then it's byvalue
            //Pass by Reference - class - passing the memory location of the array. Changes will be reflected in original

            int i_answer = i_num1 + i_num2;
            Console.WriteLine("Summing.... {0} and {1}", i_num1, i_num2);
            Console.WriteLine("The answer is..{0}", i_answer);
        }
        public static int Methods_AddReturn(int i_num1, int i_num2)
        {
            //PUblic - anyone can use it across classes
            //Private - can only be used within class
            //void means it doesn't return anything
            //using int will cause it to expect an int as the return value

            int i_answer = i_num1 + i_num2;
            return i_answer;
         
        }
        public static void Methods_AddArray(int[] AddArray)
        {
            /* Pass by Reference Example using Array             
             
            code used in Main
            int[] AddArray2 = new int[1];
            AddArray2[0] = 32;
            Console.WriteLine(AddArray2[0]);
            Methods_AddArray(AddArray2);
            Console.WriteLine(AddArray2[0]);

             */

            AddArray[0] += 3;
        }
        public static void Methods_PassByRef(ref int PassByRefValue)
        {
            //Pass by reference example
            /*
                
            Calling from main...

            int test = 50;
           Methods_PassByRef(ref test);
           Console.WriteLine(test); 
              */
            PassByRefValue += 3;
        }
        public static void Methods_PassByRefOutKeyword(int a, int b, out int Added, out int Multiplied)
        {
            //Pass by reference example with Out Keyword to return multiple values
            /*
                
            Calling from main...

               int add;
            int mult;
            Methods_PassByRefOutKeyword(2, 5, out add, out mult);

            Console.WriteLine(add);
            Console.WriteLine(mult);
              */

            Added = a + b;
            Multiplied = a * b;

        }
        public static void Methods_PrintArrayParamsKeyword(params int [] array)
        {
              //Using Keyword Params allows for multiple parameters
            /* example of calling in Main
             *    int[] myarray = new int[5] { 1,2,3,4,5};
            Methods_PrintArrayParamsKeyword(myarray);
            Methods_PrintArrayParamsKeyword(6,7,59,23);
            */
            for(int i = 0; i <array.Length; i++)
            {
              Console.WriteLine(array[i]);
            }

         }   
        public static void Methods_Overloading_Add(int x, int y)
        {
            //Example of Method Overloading, which allows for mulitple versions of the same function
            //Functions have to be named the same but don't have to have the same parameter names or types.

            int answer = x + y;
            Console.WriteLine(answer);
        }
        public static void Methods_Overloading_Add(string x, string y)
        {
            //Example of Method Overloading, which allows for mulitple versions of the same function

            string answer = x + " " + y;
            Console.WriteLine(answer);
        }
        public static void Methods_Overloading_Add(double x, double y)
        {
            //Example of Method Overloading, which allows for mulitple versions of the same function
            //Methods_Overloading_Add("Hello", "World");
            //Methods_Overloading_Add(1, 3);
            //Methods_Overloading_Add(1.3, 2.0);
            double answer = x + y;
            Console.WriteLine(answer);
        }
        public static void Methods_OptionalParams_Add(int x, int y = 3, int z= 2)
        {
             // Setting a default value for Y makes the parameter optional
            int answer = x + y + z;
            Console.WriteLine(answer);

            //To call parameter by name and skip an optional parameter you can use the below logic
            //Methods_OptionalParams_Add(5,z:5);
            //this will pass in 5 to X and 5 to Z, but the default value for Y (3) is still there
            //Naming argument syntax is <name>:<value> 
        }
    }
}


