using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            //11/02/2022 
            //Hash Collection, part of system.collection

            Hashtable ht = new Hashtable();
            ht.Add(1, "monday");
            ht.Add(2, "tuesday");
            ht.Add(3, "Wednesday");

            foreach (DictionaryEntry kv in ht)
            {
                Console.WriteLine("key:{0}, Value:{1}", kv.Key, kv.Value);
            }

            //Stack //LIFO

            Stack <int> stack = new Stack<int>();  
            stack.Push(1);
            stack.Push(2);  
            stack.Push(3);  
            stack.Push(4);  
            stack.Push(5);

            foreach (var kv in stack)
                Console.WriteLine(kv + ",");

            //pop()
            //peek()
            //push()
            //clear()
            
            Console.WriteLine(stack.Contains(2));
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Count());
            Console.WriteLine(stack.Peek());


            //queue - FIFO

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.WriteLine(queue.Count());

            foreach (var kv in queue)
            {
                Console.WriteLine(kv);
            }

            //Contains
            //Peek
            //push
            //clear

            Console.WriteLine(queue.Peek());


            //Tuple
            //Only 8 element can store

            var customer = Tuple.Create(1,2,3,4,5,6,7,9);

            var customers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11));

            Console.WriteLine(customers.Rest.Item1);  //10,11,13
            Console.WriteLine(customers.Rest.Item1.Item1);
            Console.WriteLine(customer.Item2);

            */

            /*

            container user = new container();
            while (true)
            {
                Console.WriteLine("1.   Book Container\n2.  Read Data\n3.   Exit");
                string answer = Console.ReadLine();

                if (answer == "1" || answer == "Book Container")
                {
                    user.book();
                }
                else if (answer == "2" || answer == "Read Data")
                {
                    user.readdata();

                }
                else if(answer == "3" || answer == "Exit")
                {
                    break;
                }
                else
                {
                

            }


            //user.containerbook();
            //user.readdata();
            



            //Task 3
            */

            IDictionary<int, string> ports = new Dictionary<int, string>();
            ports.Add(1, "India");
            ports.Add(2, "USA");
            ports.Add(3, "Norwey");
            ports.Add(4, "China");

            IDictionary<int, string> InBetweenPort = new Dictionary<int, string>();
            InBetweenPort.Add(1, "Mid1");
            InBetweenPort.Add(2, "Mid2");
            InBetweenPort.Add(3, "MId3");
            ArrayList UserList = new ArrayList();
            int count = 1;
            while (true)
            {
                Console.WriteLine("1.Book Container\n2.Show Booked List\n3.Exit");
                int answer= Convert.ToInt32(Console.ReadLine());
                if (answer == 1)
                {
                    try
                    {
                        Console.WriteLine("Enter UserName :");
                        UserList.Add(Console.ReadLine());  //add to userlist
                        Console.WriteLine("Enter Password :");
                        string password = Console.ReadLine();
                        foreach (KeyValuePair<int, string> pair in ports)
                        {
                            Console.WriteLine(" PortName : {0}", pair.Value);
                        }

                        Console.WriteLine("Enter PortName :");
                        string ImportPortname = Console.ReadLine();
                        int pairnumber=0;
                        foreach (KeyValuePair<int, string> pair in ports)
                        {
                            if (pair.Value == ImportPortname)
                            {
                                pairnumber = pair.Key;
                            }
                        }
                          
                        if (ports.ContainsKey(pairnumber))   //to check weather entered port name is exits or not in port dictionary
                        {
                            UserList.Add(ImportPortname);
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
                            string ExportportName = Console.ReadLine();
                            foreach (KeyValuePair<int, string> pair in ports)
                            {
                                if (pair.Value == ImportPortname)
                                {
                                    pairnumber = pair.Key;
                                }
                            }


                        }
                        else
                        {
                            break;
                        }

                        UserList.Add(Console.ReadLine());
                        foreach(KeyValuePair<int, string> pair in InBetweenPort)
                        {
                            Console.WriteLine("InBetweenPortName : {0}",pair.Value);
                        }
                        UserList.Add(Console.ReadLine());
                        UserList.Add(1000);

                        FileStream fs = new FileStream("C:/Users/Lenovo/source/repos/Day 5/Day 5/reciept.txt", FileMode.Append, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fs);
                        string str;
                        for (int i = 0; i < count; i++)
                        {
                            str = "UserName:" + UserList[i] + "     Import Port Name:"+UserList[i+1]+"      Reaciver Port Name:"+UserList[i+2]+"        Cost:"+UserList[i+3];  //i*2 for access username and containerlist[i] for acess booked id
                            sw.WriteLine(str);
                        }
                        sw.Flush();
                        sw.Close();
                        fs.Close();
                        Console.WriteLine("Booking SuccesFull ");
                        count++;
                    }
                    catch
                    {
                        Console.WriteLine("No container Available");
                        break;
                    }
                }
                else if(answer == 2)
                {
                    String path = @"C:/Users/Lenovo/source/repos/Day 5/Day 5/reciept.txt";

                    String[] lines;
                    lines = File.ReadAllLines(path);
                    int countline = 0;
                    try
                    {
                        while (lines[countline] != null)
                        {
                            Console.WriteLine(lines[countline]);
                            countline++;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("No More Data Available !!!");
                    }
                }
                else if(answer==3)
                {
                    break;
                }
                else
                {
                    continue;
                }

            }



    }
        public class container
        {
            public void book()
            {
                //Task 1
                //using Queue

                /*

                Queue queue = new Queue();
                int count = 1;
                while(true)
                {
                    Console.WriteLine("DO you want to book container Yes/No" );
                    string answer = Console.ReadLine();

                    if (answer == "Yes")
                    {
                        try
                        {
                            if(count == 9)
                            {
                                Console.WriteLine("No container Available");
                                break;
                            }
                            queue.Enqueue(count);
                            Console.WriteLine("Booking SuccesFull ");
                            count++;
                        }
                        catch
                        {
                            Console.WriteLine("No container Available");
                            break;
                        }
                    }
                    else
                    {
                        continue;
                    }
                    foreach (var item in queue)
                    {
                        Console.WriteLine(item);
                    }
                }
                */


                //Task 2
                //using ArrayList


                ArrayList containerlist = new ArrayList();
                ArrayList UserList = new ArrayList();
                int count = 1;
                while (true)
                {
                    Console.WriteLine("DO you want to book container Yes/No");
                    string answer = Console.ReadLine();

                    if (answer == "Yes")
                    {
                        try
                        {
                            Console.WriteLine("Enter UserName :");
                            UserList.Add(Console.ReadLine());  //add to userlist
                            Console.WriteLine("Enter Password :");
                            UserList.Add(Console.ReadLine());  //add to userlist
                            if (containerlist.Count == 9)  //available container is 8
                            {
                                Console.WriteLine("No container Available");
                                break;
                            }
                            containerlist.Add(count);
                            FileStream fs = new FileStream("C:/Users/Lenovo/source/repos/Day 5/Day 5/reciept.txt", FileMode.Append, FileAccess.Write);
                            StreamWriter sw = new StreamWriter(fs);
                            string str;
                            for(int i = 0; i < count; i++)
                            {
                                str = "UserName:    " + UserList[i * 2] + "Container Booked ID:    " + containerlist[i];  //i*2 for access username and containerlist[i] for acess booked id
                                sw.WriteLine(str);
                            }
                            sw.Flush();
                            sw.Close();
                            fs.Close();
                            Console.WriteLine("Booking SuccesFull ");
                            count++;
                        }
                        catch
                        {
                            Console.WriteLine("No container Available");
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }

                }

            }

            //Task 3
            public void readdata()
            {
                String path = @"C:/Users/Lenovo/source/repos/Day 5/Day 5/reciept.txt";

                String[] lines;
                lines = File.ReadAllLines(path);
                int count = 0;
                try
                {


                    while (lines[count] != null)
                    {
                        Console.WriteLine(lines[count]);
                        count++;
                    }
                }
                catch
                {
                    Console.WriteLine("No More Data Available !!!");
                }

            }
            public void containerbook()
            {
               
                ArrayList UserList = new ArrayList();
                ArrayList PortList = new ArrayList();
                while(true)
                {
                    Console.WriteLine("1. Add User\n2. Add Port\n3.  Exit");
                    int answer = Convert.ToInt32(Console.ReadLine());
                    if(answer == 3)
                    {
                        break;
                    }

                    switch(answer)
                    {
                        case 1:
                            Console.WriteLine("Enter Name :");
                            UserList.Add(Console.ReadLine());
                            Console.WriteLine("Enter Username :");
                            UserList.Add(Console.ReadLine());
                            Console.WriteLine("Enter Password :");
                            UserList.Add(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("Enter Port Name:");
                            PortList.Add(Console.ReadLine());
                            Console.WriteLine("Enter Port ID: ");
                            PortList.Add(Console.ReadLine());
                            break;


                    }


                }
                Console.WriteLine("User List: ");
                for (int i = 0; i < (UserList.Count - 4); i++)
                {
                    Console.WriteLine(" Name:" + UserList[i] + " UserName:" + UserList[i + 1] + " Password:" + UserList[i + 2]);
                }

                Console.WriteLine("Port List:");
                for (int i = 0; i < (UserList.Count - 3); i++)
                {
                    Console.WriteLine(" PortName:" + PortList[i] + " PortID:" + PortList[i + 1]);
                }
            }
        }
    }
}
