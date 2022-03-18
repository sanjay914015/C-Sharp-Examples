using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace connectdatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=EFCYIT-LTR910;Initial Catalog=below50; Integrated Security=True");
            SqlConnection sqlcon1 = new SqlConnection(@"Data Source=EFCYIT-LTR910;Initial Catalog=above50; Integrated Security=True");

            Console.WriteLine("Enter Unique ID: ");
            string ID = Console.ReadLine();

            Console.WriteLine("Enter First Name :");
            string First_Name = Console.ReadLine();

            Console.WriteLine("Enter Last Name :");
            string Last_Name = Console.ReadLine();

            Console.WriteLine("Enter Gender :");
            string Gender = Console.ReadLine();

            Console.WriteLine("Enter Age :");
            int age= Convert.ToInt32(Console.ReadLine());

            if(age <= 50)
            {
                if(Gender == "Male" || Gender == "male")
                {
                    SqlDataAdapter sqlmale = new SqlDataAdapter("insert into male(ID, First_Name, Last_Name, Gender) values('"+ID+ "', '" + First_Name + "', '" + Last_Name + "','Male')", sqlcon);
                    DataTable dtbl = new DataTable();
                    sqlmale.Fill(dtbl);
                    Console.ReadLine();

                }
                else
                {
                    SqlDataAdapter sqlfemale = new SqlDataAdapter("insert into female(ID, First_Name, Last_Name, Gender) values('" + ID + "', '" + First_Name + "', '" + Last_Name + "','Female')", sqlcon);
                    DataTable dtbl = new DataTable();
                    sqlfemale.Fill(dtbl);
                    Console.ReadLine();

                }
            }
            else
            {
                if (Gender == "Male" || Gender == "male")
                {
                    SqlDataAdapter sqlmale = new SqlDataAdapter("insert into male(ID, First_Name, Last_Name, Gender) values('" + ID + "', '" + First_Name + "', '" + Last_Name + "','Male')", sqlcon1);
                    DataTable dtbl = new DataTable();
                    sqlmale.Fill(dtbl);
                    Console.ReadLine();

                }
                else
                {
                    SqlDataAdapter sqlfemale = new SqlDataAdapter("insert into female(ID, First_Name, Last_Name, Gender) values('" + ID + "', '" + First_Name + "','" + Last_Name + "','Female')", sqlcon1);
                    DataTable dtbl = new DataTable();
                    sqlfemale.Fill(dtbl);
                    Console.ReadLine();

                }
            }
        }
    }
}
