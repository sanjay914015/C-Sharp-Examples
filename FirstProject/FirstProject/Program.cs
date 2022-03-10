using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public interface Vehicle
    {
        void car();
    }
    class Drive: Vehicle
    { 
        public void car()
        {
            Console.WriteLine("the Car");
        }
    }

    internal class Program
    {
        Program()
        {
            //constructor
        }
        static void Main(string[] args)
        { 
            /*
            Console.WriteLine("Hello World");
            //string message = Console.ReadLine(); //strings and all called fields.

            // access modifiers - public, private , internal and protected.
            // Data Types
            // C# is strongly and static type language
            int numberone = 190;
            Console.WriteLine(numberone);

            // explicitly typed
            int m = 150;

            // implicitly typed but we cannot assigned multiple value using var 
            var a = 10;

            // Data-types 2 types: value types and refrence types

            //4 types value types: simple, enum, struct, nullable
            //4 refrence types; classtypes, interface, arrya types, delegate types

            uint gi = 100u;
            float f = 10.3f;
            double d = 122222.4d;
            long l = 324324234234234l; ;
            ulong ul = 2343242334234324ul;
            decimal nn = 110.12m;

            //default values for int 0, char /0, boolean=flase
            int im = default(int);

            //strings

            string s = "message1";
            char[] ch = { 'h', 'e', 'l', 'l', 'o' };
            string s1 = new string(ch);

            foreach (char c in ch)
            {
                Console.WriteLine(c);
            }

            string s2 = @"test@gmail.com";
            Console.Write(s2);
            Console.WriteLine(s2);

            string s3 = "hi \n" + "hello\n" + "value";
            Console.WriteLine(s3);

            string firstname = "Mahesh";
            string secondname = "idd";

            string personname = firstname + secondname;

            // string Interposition

            string fullname = $"Dr. {firstname} {secondname}";
            Console.WriteLine(fullname);

            //if,else if, else

            ///Task1: check even and odd

            Console.WriteLine("Enter Number to check Even Odd");
            int numbertocheck = Convert.ToInt32(Console.ReadLine());

            if(numbertocheck%2 == 0)
            {
                Console.WriteLine("Number is even");

            }
            else
            {
                Console.WriteLine("Number is Odd");
            }


            // divide string in 2 parts if its more than 5 characters
            Console.WriteLine("Enter string to concanate : ");
            string inputstring = Console.ReadLine();

            if(inputstring.Length >=5 )
            {
                Console.WriteLine(inputstring.Substring(0, inputstring.Length/2));
                Console.WriteLine(inputstring.Substring(inputstring.Length/2));

            }
            else
            {
                Console.WriteLine(inputstring);
            }

            // print factorial
            Console.WriteLine("Enter Number to find factorial :");
            int factorialnumber = Convert.ToInt32(Console.ReadLine());
            int resultofnumber = 1;

            for(int i = factorialnumber; i > 1; i--)
            {
                resultofnumber=resultofnumber * i;
            }
            Console.WriteLine(resultofnumber);

            */



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


            /*
            ///Interface

            Vehicle v = new Drive();

            v.car();


            
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


            /*
            //Day 4

            // 10/03/2022

            // Task 1 : Create List of Interface and change Lastname of List.
            

            var customers = new List<Customerdata>()
            {
                new Customerdata() { Id = 1, Fname = "James", Lname="Bond"},
                new Customerdata() { Id = 2, Fname = "Peter",  Lname="England"},
                new Customerdata() { Id = 3, Fname = "Roy", Lname="breck" }
            };

            for (int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine("ID :" + customers[i].Id + " Firstname :" + customers[i].Fname + " Lastname :" + customers[i].Lname);
            }

            Console.WriteLine("Enter Id which you want to Update");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Last Name :");
            string LastName = Console.ReadLine();

            if (id == 1)
            {
                customers[0].Lname = LastName;
            }
            else if (id == 2)
            {
                customers[1].Lname = LastName;
            }
            else if (id == 3)
            {
                customers[2].Lname = LastName;
            }
            else
                Console.WriteLine("Enter Valid ID:");

            for (int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine("ID :"+customers[i].Id+ "Firstname :"+ customers[i].Fname+ " Lastname :"+ customers[i].Lname);
            }


            */


            /*
            //Generic class

            DtStataion<int> dtStataion = new DtStataion<int>();
            dtStataion.Data = 1000;

            KeyValue<string, string> keyValue = new KeyValue<string, string>();
            keyValue.Key = "id";
            keyValue.Value = "1";
            Console.WriteLine(keyValue.Key +"   " + keyValue.Value);


            //sorted list 

            SortedList<int, string> sortedList = new SortedList<int, string>();

            sortedList.Add(1, "James");
            sortedList.Add(2, "Roy");

            foreach(var i in sortedList)
            {
                Console.WriteLine("Key:{0}, Value:{1}", i.Key, i.Value);
            }


            */




            /*
            
            //Project 1 task 2: Container management using Collections and Import Export using Case statements

            ArrayList UserList = new ArrayList();

            Console.WriteLine("Enter User Id: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            UserList.Add(ID);

            Console.WriteLine("Import or Export");
            string answer = Console.ReadLine();
            var customers = new List<Customerdata>()
            {
                new Customerdata() { Id = 1, Fname = "James", Lname="Bond"},
                new Customerdata() { Id = 2, Fname = "Peter",  Lname="England"},
                new Customerdata() { Id = 3, Fname = "Roy", Lname="breck" }
            };

            var ports = new List<StartPort>()
            {
                new StartPort() { Id=1, PickupPort = "India" , MidSeaCost = 2000},
                new StartPort() { Id=2, PickupPort = "USA", MidSeaCost = 5000 },
                new StartPort() { Id=3, PickupPort = "China", MidSeaCost = 10000 },
                new StartPort() { Id=4, PickupPort = "Norwey", MidSeaCost = 22000 }

            };


            switch (answer)
            {
                case "Import":

                    for (int i = 0; i < ports.Count; i++)
                    {
                        Console.WriteLine("ID :" + ports[i].Id + " Firstname :" + ports[i].PickupPort + " Lastname :" + ports[i].MidSeaCost);
                    }
                    Console.WriteLine(" Enter  Id of Port From You Imported :");
                    int startportid = Convert.ToInt32(Console.ReadLine());

                    UserList.Add(ports[startportid-1].PickupPort);

                    for (int i = 0; i < ports.Count; i++)
                    {
                        if (ports[i].Id == startportid)
                        {

                        }
                        else
                        {
                            Console.WriteLine("ID :" + ports[i].Id + " PortName :" + ports[i].PickupPort + " MidSeaCost :" + ports[i].MidSeaCost);
                        }
                    }
                        Console.WriteLine(" Enter  Id of Reciever Port");
                        int endportid = Convert.ToInt32(Console.ReadLine());
                        UserList.Add(ports[endportid - 1].PickupPort);

                        double finalcost = ports[startportid-1].MidSeaCost + ports[endportid - 1].MidSeaCost;

                        UserList.Add(finalcost);

                    
                    break;
                case "Export":
                    for (int i = 0; i < ports.Count; i++)
                    {
                        Console.WriteLine("ID :" + ports[i].Id + " PortName :" + ports[i].PickupPort + " MidSeaCost :" + ports[i].MidSeaCost);
                    }
                    Console.WriteLine(" Enter  Id of Port From You want to Export :");
                    int Exportportid = Convert.ToInt32(Console.ReadLine());

                    UserList.Add(ports[Exportportid - 1].PickupPort);

                    for (int i = 0; i < ports.Count; i++)
                    {
                        if (ports[i].Id == Exportportid)
                        {

                        }
                        else
                        {
                            Console.WriteLine("ID :" + ports[i].Id + " PortName :" + ports[i].PickupPort + " MidSeaCost :" + ports[i].MidSeaCost);
                        }
                    }
                    Console.WriteLine(" Enter  Id of Reciever Port");
                    int Destinationportid = Convert.ToInt32(Console.ReadLine());
                    UserList.Add(ports[Destinationportid - 1].PickupPort);

                    int Exportcost = ports[Exportportid - 1].MidSeaCost + ports[Destinationportid - 1].MidSeaCost;

                    UserList.Add(Exportcost);
                    break;

                default:
                    Console.WriteLine("Enter Valid Input");
                    break;
            }

            Console.WriteLine("UserId :" + UserList[0] + "  StartPort:" + UserList[1] + "   EndPort:" + UserList[2] + " Cost:" + UserList[3]);


            */


            /*

            //Dictionary

            IDictionary<int, string> map = new Dictionary<int, string>();
            map.Add(1, "James");
            map.Add(1, "Roy");
            map.Add(3, "Roy");

            foreach (KeyValuePair<int, string> pair in map)
            {
                Console.WriteLine("Key :{0} , Value : {1}", pair.Key, pair.Value);
            }


            */




            /*
            //Task 3 : Using IDictionary create ports name and id and asked user to enter port name and then find cost

            IDictionary<int, string> ports = new Dictionary<int, string>();
            ports.Add(1, "India");
            ports.Add(2, "USA");
            ports.Add(3, "Norwey");
            ports.Add(4, "China");

            //Import Port Name 

            foreach (KeyValuePair<int, string> pair in ports)
            {
                Console.WriteLine(" PortName : {0}", pair.Value);
            }

            Console.WriteLine("Enter PortName :");
            string ImportPortname = Console.ReadLine();
            int portid;

            foreach (KeyValuePair<int, string> pair in ports)
            {
                if (pair.Value == ImportPortname)
                {
                    portid = pair.Key;
                }
                else
                {
                    Console.WriteLine(" PortName : {0}", pair.Value);
                }
            }
            Console.WriteLine("Enter Destination Port :");
            string DestiPortName = Console.ReadLine();

            foreach(KeyValuePair<int, string> pair in ports)
            {
                if(pair.Value == DestiPortName)
                {
                    int destiportid = pair.Key;
                }
            }

            Console.WriteLine("Bill");
            foreach(KeyValuePair<int, string> pair in ports)
            {
                if( ImportPortname == pair.Value )
                {
                    Console.WriteLine("Import Port Id :{0} , Import Port Name : {1}", pair.Key, pair.Value);
                }
                else if( DestiPortName == pair.Value )
                {
                    Console.WriteLine("Destination Port Id :{0} , Destination Port Name : {1}", pair.Key, pair.Value);
                }

            }
            Console.WriteLine("Amount : 1000");


            */



            /*


            //admin, user , sign up fname lname mobile(userid) password genarate password it should be visible, console visible and password should be change

            Console.WriteLine("Admin \nUser ");
            string answer = Console.ReadLine();
            ArrayList userList = new ArrayList();

            switch (answer)
            {
                case "User":
                    while (true)
                    {
                        Console.WriteLine("SignIN\nLogIN\nForgotPassword\nExit");
                        string input = Console.ReadLine();
                        if (input == "SignIN")
                        {
                            Console.WriteLine("Enter Name :");
                            string Name = Console.ReadLine();
                            Console.WriteLine("Enter Mobile NO :");
                            double MobileNo = Convert.ToDouble(Console.ReadLine());
                            userList.Add(MobileNo);
                            Console.WriteLine("Enter Secret Question and Answer:");
                            string question = Console.ReadLine();
                            string secretanswer = Console.ReadLine();
                            string password = Name + "@123";
                            userList.Add(password);
                            userList.Add(question);
                            userList.Add(secretanswer);
                            Console.WriteLine("Your Username is :" + MobileNo + " Password :" + password);
                            continue;

                        }
                        else if (input == "LogIN")
                        {
                            Console.WriteLine("Enter UserName :");
                            double enterusername = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Password :");
                            string enterpassword = Console.ReadLine();

                            if (enterusername == Convert.ToDouble(userList[0]) && enterpassword == Convert.ToString(userList[1]))
                            {
                                Console.WriteLine("Enter New password");
                                string password = Console.ReadLine();

                                userList[1] = password;
                                Console.WriteLine("UserName : " + userList[0] + " Password : " + userList[1]);
                            }
                            continue;
                        }
                        else if (input == "ForgotPassword")
                        {
                            Console.WriteLine("Enter Username");
                            double username = Convert.ToDouble(Console.ReadLine());
                            if (username == Convert.ToDouble(userList[0]))
                            {
                                Console.WriteLine("Answer the secret Question :");
                                Console.WriteLine(userList[2]);
                                string Questionanswer = Console.ReadLine();

                                if (Questionanswer == Convert.ToString(userList[3]))
                                {
                                    Console.WriteLine("Enter New Password");
                                    string password = Console.ReadLine();
                                    userList[1] = password;
                                }
                                else
                                {
                                    Console.WriteLine("User Doesn't Exists !!");
                                }
                                Console.WriteLine("UserName : " + userList[0] + " Password : " + userList[1]);
                            }
                        }
                        else if (input == "Exit")
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }

                    }
                 break;
                default:
                    Console.WriteLine("Enter Valid Input :");
                    break;
            }


            */



            /*


            //Task:6 Show button to user show than they can cancell the trip
            IDictionary<int, string> ports = new Dictionary<int, string>();
            ports.Add(1, "India");
            ports.Add(2, "USA");
            ports.Add(3, "Norwey");
            ports.Add(4, "China");

            ArrayList UserDetails = new ArrayList();

            while (true)
            {

                Console.WriteLine("1. Book Container\n2. Cancel Booking");
                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.WriteLine("Enter UserID : ");
                        int userid = Convert.ToInt32(Console.ReadLine());
                        UserDetails.Add(userid);
                        foreach (KeyValuePair<int, string> pair in ports)
                        {
                            Console.WriteLine(" PortName : {0}", pair.Value);
                        }

                        Console.WriteLine("Enter PortName :");
                        string ImportPortname = Console.ReadLine();
                        UserDetails.Add(ImportPortname);
                        foreach (KeyValuePair<int, string> pair in ports)
                        {
                            if (pair.Value == ImportPortname)
                            {
                            }
                            else
                            {
                                Console.WriteLine(" PortName : {0}", pair.Value);
                            }
                        }
                        Console.WriteLine("Enter Destination Port :");
                        string DestiPortName = Console.ReadLine();
                        UserDetails.Add(DestiPortName);
                        Console.WriteLine("Enter trip Date yyyy/mm/dd format:");
                        string dt2 = Console.ReadLine();
                        UserDetails.Add(dt2);
                        break;

                    case 2:
                        Console.WriteLine("Enter UserId :");
                        int id = Convert.ToInt32(Console.ReadLine());
                        if( id == Convert.ToInt32(UserDetails[0]))
                        {
                            Console.WriteLine("UserID: "+UserDetails[0]+" StartPort: "+UserDetails[1]+" Endport "+UserDetails[2]+" Date: "+UserDetails[3]);
                            string dt3 = DateTime.Now.ToString("yyyy/MM/dd");
                            var difference = (Convert.ToDateTime(UserDetails[3]) - Convert.ToDateTime(dt3)).Days;

                            if(Convert.ToInt32(difference) <= 3 )
                            {
                                Console.WriteLine("You cannot Cancel Book Container");
                            }
                            else
                            {
                                Console.WriteLine("Cancel Booking SuccessFull");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Enter Valid UserID !!!");
                            break;
                        }
                        break;
                    default:
                        Console.WriteLine("Enter Valid Input :");
                        break;

                }

            }

            */

            //Task : Given by the Naynesh and Varun
            //For Now Condtion there is Only One user we can store multiuser in arraylist but its gonna lengthy
            IDictionary<int, string> ports = new Dictionary<int, string>();
            ports.Add(1, "India");
            ports.Add(2, "USA");
            ports.Add(3, "Norwey");
            ports.Add(4, "China");
            while (true)
            {
                Console.WriteLine("User\nAdmin\nExit");
                string asw = Console.ReadLine();
                ArrayList userList = new ArrayList();
                ArrayList UserDetails = new ArrayList();
                if (asw == "Exit")   // For Exit from Program
                {
                    break;
                }
                switch(asw)
                {
                    case "User":
                        while (true)
                        {
                            Console.WriteLine("SignIN\nLogIN\nForgotPassword\nExit");
                            string input = Console.ReadLine();
                            if (input == "SignIN")
                            {
                                Console.WriteLine("Enter Name :");
                                string Name = Console.ReadLine();
                                Console.WriteLine("Enter Mobile NO :");
                                double MobileNo = Convert.ToDouble(Console.ReadLine());
                                userList.Add(MobileNo);
                                Console.WriteLine("Enter Secret Question and Answer:");
                                string question = Console.ReadLine();
                                string secretanswer = Console.ReadLine();
                                string password = Name + "@123";
                                userList.Add(password);
                                userList.Add(question);
                                userList.Add(secretanswer);
                                Console.WriteLine("Your Username is :" + MobileNo + " Password :" + password);
                                continue;

                            }
                            else if (input == "LogIN")
                            {
                                Console.WriteLine("Enter UserName :");
                                double enterusername = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Enter Password :");
                                string enterpassword = Console.ReadLine();
                                if (enterusername == Convert.ToDouble(userList[0]) && enterpassword == Convert.ToString(userList[1]))
                                {

                                    Console.WriteLine("DO you want to Change Password Yes/No:");
                                    string userchoice = Console.ReadLine();
                                    if(userchoice == "Yes")
                                    {
                                        Console.WriteLine("Enter New password");
                                        string password = Console.ReadLine();
                                        userList[1] = password;
                                        Console.WriteLine("UserName : " + userList[0] + " Password : " + userList[1]);
                                    }
                                    else
                                    {
                                        while (true)
                                        {

                                            Console.WriteLine("1. Book Container\n2. Cancel Booking\n3. Exit");
                                            int inputforcontainer = Convert.ToInt32(Console.ReadLine());
                                            int flag = 1;

                                            switch (inputforcontainer)
                                            {
                                                case 1:
                                                    UserDetails.Add(userList[0]);
                                                    foreach (KeyValuePair<int, string> pair in ports)
                                                    {
                                                        Console.WriteLine(" PortName : {0}", pair.Value);
                                                    }

                                                    Console.WriteLine("Enter PortName :");
                                                    string ImportPortname = Console.ReadLine();
                                                    UserDetails.Add(ImportPortname);
                                                    foreach (KeyValuePair<int, string> pair in ports)
                                                    {
                                                        if (pair.Value == ImportPortname)
                                                        {
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine(" PortName : {0}", pair.Value);
                                                        }
                                                    }
                                                    Console.WriteLine("Enter Destination Port :");
                                                    string DestiPortName = Console.ReadLine();
                                                    UserDetails.Add(DestiPortName);
                                                    Console.WriteLine("Enter trip Date yyyy/mm/dd format:");
                                                    string dt2 = Console.ReadLine();
                                                    UserDetails.Add(dt2);
                                                    break;

                                                case 2:
                                                    Console.WriteLine("UserID: " + UserDetails[0] + " StartPort: " + UserDetails[1] + " Endport " + UserDetails[2] + " Date: " + UserDetails[3]);
                                                    string dt3 = DateTime.Now.ToString("yyyy/MM/dd");
                                                    var difference = (Convert.ToDateTime(UserDetails[3]) - Convert.ToDateTime(dt3)).Days;
                                                    Console.WriteLine(difference);

                                                    if (Convert.ToInt32(difference) <= 3)
                                                    {
                                                        Console.WriteLine("You cannot Cancel Book Container");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Cancel Booking SuccessFull");
                                                        UserDetails.Clear();
                                                    }
                                                    break;
                                                case 3:
                                                    flag = 0;
                                                    break;
                                                default:
                                                    Console.WriteLine("Enter Valid Input :");
                                                    break;

                                            }
                                            if(flag == 0)
                                            {
                                                break;
                                            }

                                        }

                                    }

                                   
                                }
                                else
                                {
                                    Console.WriteLine("Please Enter Valid Username or Password");
                                }



                            }
                            else if (input == "ForgotPassword")
                            {
                                Console.WriteLine("Enter Username");
                                double username = Convert.ToDouble(Console.ReadLine());
                                if (username == Convert.ToDouble(userList[0]))
                                {
                                    Console.WriteLine("Answer the secret Question :");
                                    Console.WriteLine(userList[2]);
                                    string Questionanswer = Console.ReadLine();

                                    if (Questionanswer == Convert.ToString(userList[3]))
                                    {
                                        Console.WriteLine("Enter New Password");
                                        string password = Console.ReadLine();
                                        userList[1] = password;
                                    }
                                    else
                                    {
                                        Console.WriteLine("User Doesn't Exists !!");
                                    }
                                    Console.WriteLine("UserName : " + userList[0] + " Password : " + userList[1]);
                                }
                            }
                            else if (input == "Exit")
                            {
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        break;
                    case "Admin":
                        for(int i=0; i<userList.Count; i++)
                        {
                            Console.Write(userList[i]+"    ");
                        }
                        for (int i = 0; i < UserDetails.Count; i++)
                        {
                            Console.Write(UserDetails[i] + "    ");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Input !!");
                        break;
                }
            }





        }

     

        //Container Management Collection

        public class StartPort
        {
            
            public string PickupPort { get; set; }
            public int MidSeaCost { get; set; }
            public int Id { get; set; }
        }




        // Generic Classes


        class DtStataion<T>
        {
            public T Data { get; set; }
        }
        class KeyValue<TKey, TValue>
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
        }



        //10/03 Task 1

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

                if( age < 25)
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
       
        //Task 6
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
        }

        //Task
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
