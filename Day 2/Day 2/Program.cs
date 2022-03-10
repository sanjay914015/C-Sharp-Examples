using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    public interface Vehicle
    {
        void car();
    }
    class Drive : Vehicle
    {
        public void car()
        {
            Console.WriteLine("the Car");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            // Day 2 All Tasks

            /*
            //Task 1: if user enter even number than print message 
            Console.WriteLine("Enter Number :");
            int numbertwo = Convert.ToInt32(Console.ReadLine());
            if(numbertwo%2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("NUmber is Odd");
            }
            */



            /*
            //Date and Time

            DateTime dt = new DateTime();
            Console.WriteLine(dt);

            DateTime dt2 = new DateTime(2022,03,03,03,10,20,DateTimeKind.Utc);
            Console.WriteLine(dt2);

            Console.WriteLine(DateTime.MinValue.Ticks);


            DateTime CurrentDateTimeUTC = DateTime.UtcNow;
            Console.WriteLine(CurrentDateTimeUTC);
            */



            /*

            //task 2 : Count Age by birthdate

            DateTime today = DateTime.Today;
            Console.WriteLine(today);
            Console.WriteLine("Enter Birthdate :");
            string userinput = Console.ReadLine();

            DateTime birthdate = Convert.ToDateTime(userinput);
            Console.WriteLine(birthdate);
            Console.WriteLine(today - birthdate);
            int days = Convert.ToInt32((today - birthdate).Days);  
            Console.Write("Your age is :");
            Console.WriteLine((days)/365);



            DateTime CurrentDateTime = DateTime.Now;
            string CurrDateTime = CurrentDateTime.ToString();
            Console.WriteLine(CurrDateTime);


            */


            /*
            //Struct Data Type.

            Person person = new Person("James", "Bond", "James Bond");
            Console.WriteLine(person.Name);
            Console.WriteLine(person.FirstName);


            // String Builder , it comes from libraly system.linq, its mutable
            //  when dealing with string builder its important to keep data reality

            StringBuilder sb = new StringBuilder("Good Morning");  // initial capacity 15
            Console.WriteLine(sb[0]);

            for (int i = 0; i < sb.Length; i++)
            {
                Console.WriteLine(sb[i]);
            }
            //sb.Insert(7, "PI");
            //Console.WriteLine(sb);

            sb.Remove(0, 4);
            Console.WriteLine(sb);

            sb.Replace("Morning", "Night");
            Console.WriteLine(sb);

            */

            /*

            // Task3 : enter full name. print name . give option to append

            Console.WriteLine("Enter FullName : ");
            string FullName = Console.ReadLine();

            StringBuilder Fullname = new StringBuilder(FullName);
            Console.WriteLine(Fullname);

            Console.WriteLine("Do You want to apped String Write yes or no :");
            String answer = Console.ReadLine();

            if (answer == "yes")
            {
                Console.WriteLine("Enter string :");
                string appendtext = Console.ReadLine();

                Fullname.Append(appendtext);
                Console.WriteLine(Fullname);
            }
            else
            {
                Console.WriteLine(Fullname);
            }

            */


            /*
            //Task 4 : using struct put object value in StringBuilder
            StringBuilder sb3 = new StringBuilder("My Name is ");

            StringBuilderExample example = new StringBuilderExample();

            example.FirstName = "sanjay ";
            example.LastName = "chauhan";


            sb3.Append(example.FirstName);
            sb3.Append(example.LastName);
            Console.WriteLine(sb3);

            


            //Get object Type and compare to any data tyope;

            Console.WriteLine(example.FirstName.GetType() == typeof(string));
            */

            /*

            // Nullable Data type;
            Nullable<int> i = null;
            i = 10;
            Console.WriteLine(i.Value);
            int? a = null;



            //Task 5 : create struct customername , totalamount, age , switch if the age is less 25 than 10% discount , 25 to 35 15%, 35 to 45 20%, above 50% 50%

            Customer customer = new Customer("Sanjay",100000, 71);
            double finalamount = 1;
            Console.WriteLine(Convert.ToInt32(customer.age / 25));

            switch (Convert.ToInt32(customer.age/25))
            {
                case 1:
                    finalamount = customer.amount - ((customer.amount)*(0.1));   // age 1 to 25 10% discount
                    break;
                case 2:
                    if (customer.age / 25 <= 1.5 || customer.age / 25 > 1)
                    {
                        finalamount = customer.amount - (customer.amount * (0.15));  // age 25 to 37 15% discount
                    }
                    else
                    {
                        finalamount = customer.amount -  (customer.amount * (0.25));  // age 38 to 75 25% discount
                    }
                    break;
                case 3:
                    finalamount = customer.amount -  (customer.amount * (0.5));  // >75 age 50% discount
                    break;
                default:
                    finalamount = customer.amount - (customer.amount * (0.5));  // 50% discount
                    break;

            }
            Console.WriteLine("Mr "+customer.name+" your age is "+customer.age+" That's Why Your Final Amount After discount is :" + finalamount);

            */

            /*

            //enum operators

            Console.WriteLine(months.January);
            int p = (int) months.January;
            Console.WriteLine(p);


            //Value assign at runtime

            dynamic psw = 1;
            dynamic pswq = "James";
            Console.WriteLine(pswq.GetType()); 
            Console.WriteLine(psw.GetType());

            */
        }
        //enum operators
        enum months
        {
            January,
            February,
            March
        }


        //structure example
        struct Person
        {
            public string Name;
            public string FirstName;
            public string LastName;


            //Parametarized Construction

            public Person(string Name, string FirstName, string LastName)
            {
                this.Name = Name;
                this.FirstName = FirstName;
                this.LastName = LastName;
            }
        }
        struct StringBuilderExample
        {
            public string firstname;
            public string lastname;
            public string FirstName
            {
                get
                {
                    return firstname;
                }
                set
                {
                    firstname = value;
                }
            }
            public string LastName
            {
                get
                {
                    return lastname;
                }
                set
                {
                    lastname = value;
                }
            }
            struct Customer
            {
                public string name;
                public float amount;
                public float age;
                public Customer(string Name, int amount, int age)
                {
                    this.name = Name;
                    this.age = age;
                    this.amount = amount;
                }
            }
        }
    }
}
