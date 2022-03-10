using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
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
