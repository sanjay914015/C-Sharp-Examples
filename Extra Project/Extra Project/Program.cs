using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

     

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
                switch (asw)
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
                                    if (userchoice == "Yes")
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
                                            if (flag == 0)
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
                        for (int i = 0; i < userList.Count; i++)
                        {
                            Console.Write(userList[i] + "    ");
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

    }
}
