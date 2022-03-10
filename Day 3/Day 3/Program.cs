using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Day 3
            //09-03-2022

            //Task 1
            //multiple interface first inteface calculate age,base=50000, premium cost,if age is below 25 cost will be multiply by 10, if greater than 25 then *20  

            Details details = new customer();
            Premium Calculate = new customer();
            details.calculateage();
            Calculate.calculatecost();

            */

            /*
            //Array
            int[] numbers = { 10, 20, 30 };

            foreach (int number in numbers)
                Console.WriteLine(number);

            */

            /*

            // Task 2: create array , try to store lots of name in one array and second age. 

            string[] array1 = new string[2];
            int[] array2 = new int[2];

            for(int i =0; i < array1.Length; i++)
            {
                Console.WriteLine("Enter Name :");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter age :");
                    int age = Convert.ToInt32(Console.ReadLine());


                    array1[i] = name;
                    array2[i] = age;

            }
            for(int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
                Console.WriteLine(array2[i]);
            }

            */


            /*

            //Task 3 : two array Male and Femle

            string[] Male = new string[5];
            string[] Female = new string[5];

            for( int i =0; i< 5; i++)
            {
                Console.WriteLine("If Male then write male else write female :");
                string name = Console.ReadLine();

                if(name == "male")
                {
                    string malename = Console.ReadLine();
                    Male.Append(malename);
                }
                else
                {
                    string Femlaename = Console.ReadLine();
                    Female.Append(Femlaename);
                }
            }
            Console.WriteLine("Male List :");
            Console.WriteLine(Male);
            Console.WriteLine("Female list :");
            Console.WriteLine(Female);  

            */

            /*

            // Inbuilt Binary Search Function

            int[] numbers = { 10, 20, 30, 40,50 };

            Console.WriteLine(Array.BinarySearch(numbers, 30));

            //Task when index is outofbound then add another array into array

            int[] array1 = new int[5];
            int[][] array2 = new int[5][5];
 
            int flag=0;  //for checking while condition
            int count=0; //for count single array range
            int counterforarray = 0;  //index of multidimension array 
            while(flag == 0)
            {
                Console.WriteLine(" Enter 1. Enter element and 2. Exit");
                int answer= Convert.ToInt32(Console.ReadLine());

                if(answer == 1)
                {
                    flag = 0;
                    Console.WriteLine("Enter Number :");
                    int number = Convert.ToInt32(Console.ReadLine());
                    if(count == 5 && counterforarray != 5)
                    {
                        array2[counterforarray] = array1;
                        counterforarray++;
                        count = 0;
                    }
                    else
                    {
                        if ( counterforarray == 5)
                          {
                                flag=1;
                                break;     
                           }
                        array1[count] = number;
                        count++;

                    }

                }
                else
                {
                    flag = 1;
                }
            }
            for(int i = 0; i < array2.Length; i++)
            {
                for(int j = 0; j < array2.Length; j++)
                {
                    Console.Write(array2[i][j]);
                }
                Console.WriteLine("\n");
            }

            */


            //collection


            /*

            //ArrayList

            ArrayList arrayList = new ArrayList(); // size is increasingly dynamicly helps you add different types of data 

            int[] ar = { 10, 20, 30 };
            arrayList.Add(10);
            arrayList.AddRange(ar);
            Console.WriteLine(arrayList.Count);

            for(int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }


            int[] array1 = new int[5];
            ArrayList array2 = new ArrayList();

            int flag = 0;  //for checking while condition
            int count = 0; //for count single array range
            while (flag == 0)
            {
                Console.WriteLine(" Enter 1. Enter element and 2. Exit");
                int answer = Convert.ToInt32(Console.ReadLine());

                if (answer == 1)
                {
                    flag = 0;
                    Console.WriteLine("Enter Number :");
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (count == 5)
                    {
                        array2.AddRange(array1);
                        count = 0;
                    }
                    else
                    {
                        array1[count] = number;
                        count++;

                    }

                }
                else
                {
                    flag = 1;
                }
            }
            for(int i = 0; i < array2.Count; i++)
            {
                Console.WriteLine(array2[i]);
            }


            */

            /*
            
            //List

            var numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2); 
            numbers.Add(3);
            numbers.Add(4);

            Console.WriteLine(numbers.Count);
            int[] arr = { 10, 20, 30 };
            numbers.AddRange(arr);
            Console.WriteLine(numbers.Count);

            */

        }
        public class Customerdata
        {
            public int Id { get; set; }
            public string Fname { get; set; }
            public string Lname { get; set; }
        }

        public interface Details
        {
            void calculateage();

        }
        public interface Premium
        {
            void calculatecost();
        }


        class customer : Details, Premium
        {
            public int age;
            public int Name;


            public void calculateage()
            {
                Console.WriteLine("Enter Name");
                string Name = Console.ReadLine();


                DateTime today = DateTime.Today;
                Console.WriteLine(today);
                Console.WriteLine("Enter Birthdate :");
                string userinput = Console.ReadLine();

                DateTime birthdate = Convert.ToDateTime(userinput);
                age = Convert.ToInt32((today - birthdate).Days);
            }
            public void calculatecost()
            {

                if (age < 25)
                {
                    Console.WriteLine(Name);
                    Console.WriteLine("Your Premium is " + (50000 * 10));
                }
                else
                {
                    Console.WriteLine(Name);
                    Console.WriteLine("Your Premium is " + (50000 * 20));
                }

            }

        }

    }
}
