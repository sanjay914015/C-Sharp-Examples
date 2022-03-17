using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Today_Project
{
    internal class Program
    {
        static int tableWidth = 73;
        static void Main(string[] args)
        {
            Console.WriteLine("Admin \nUser ");
            string answer = Console.ReadLine();
            ArrayList userList = new ArrayList();
            double MobileNo = 0;
            Console.Clear();

            switch (answer)
            {
                case "User":
                    while (true)
                    {
                        Console.WriteLine("SignIN\nLogIN\nForgotPassword\nExit");
                        string input = Console.ReadLine();

                        Console.Clear();
                        if (input == "SignIN")
                        {
                            Console.WriteLine("Enter Name :");
                            string Name = Console.ReadLine();
                            try
                            {
                                Console.WriteLine("Enter Mobile NO :");
                                MobileNo = Convert.ToDouble(Console.ReadLine());
                                userList.Add(MobileNo);
                            }
                            catch
                            {
                                Console.WriteLine("Please Enter valid Mobile Number");
                                continue;
                            }
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
                case "Admin":
                    while (true)
                    {
                        Console.WriteLine("LogIN\nExit");
                        string input = Console.ReadLine();
                        Console.Clear();

                        if (input == "LogIN")
                        {
                            Console.WriteLine("Enter UserName :");
                            string enterusername = Console.ReadLine();
                            Console.WriteLine("Enter Password :");
                            string enterpassword = Console.ReadLine();
                            Console.Clear();

                            if (enterusername == "Admin" && enterpassword == "Admin")
                            {
                                Console.WriteLine("UserName : " + enterusername + " Password : " + enterpassword);
                                while (true)
                                {
                                    Console.WriteLine("1. User Approval 2. Exit");
                                    int asw = Convert.ToInt32(Console.ReadLine());
                                    if (asw == 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("List OF User");
                                        PrintLine();
                                        PrintRow("ID", "From Port", "To Port", "Request");
                                        PrintLine();
                                        PrintRow("", "", "", "");
                                        PrintRow("", "", "", "");
                                        PrintLine();
                                        continue;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Please Enter Valid Username and Password ::");
                                continue;
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
                    {
                        Console.WriteLine("Invalid Input ::");
                        break;
                    }
            }
        }
        static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
    }
}
