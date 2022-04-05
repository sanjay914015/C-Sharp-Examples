using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.IO;

using System.Threading.Tasks;

namespace Task_2_18_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String path = @"C:\C Sharp\C-Sharp-Examples\Task 2 18 3\test.txt";


            System.IO.StreamReader reader;
            reader = new System.IO.StreamReader(path);
            string Data = reader.ReadToEnd();
            Data = Data.Replace(" ", String.Empty);
            Console.WriteLine(Data);
            reader.Close();
            string[] values = Data.Split('*','>','~');

            for(int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
                if(values[i] == "ISA")
                {
                    for (int temp = i; temp < 100; temp++)
                    {
                        SqlConnection sqlcon = new SqlConnection(@"Data Source=EFCYIT-LTR910;Initial Catalog=product; Integrated Security=True");
                        SqlDataAdapter sqlmale = new SqlDataAdapter("insert into EDI(ISA) values('" + values[temp + 1] + "')", sqlcon);
                        DataTable dtbl = new DataTable();
                        sqlmale.Fill(dtbl);
                        if(Convert.ToString(values[temp]) == "T")
                        {
                            break;
                        }
                    }
                }
                else if(values[i] == "T")
                {
                    SqlConnection sqlcon = new SqlConnection(@"Data Source=EFCYIT-LTR910;Initial Catalog=product; Integrated Security=True");
                    SqlDataAdapter sqlmale = new SqlDataAdapter("alter table EDI add GSI varchar(1000)", sqlcon);
                    DataTable dtbl = new DataTable();
                    sqlmale.Fill(dtbl);
                    int count = 1;
                    for (int temp = i; temp < 100; temp++)
                    { 
                        SqlConnection sqlcon1 = new SqlConnection(@"Data Source=EFCYIT-LTR910;Initial Catalog=product; Integrated Security=True");
                        SqlDataAdapter sqlmale1 = new SqlDataAdapter("update EDI set GS= '" + values[temp + 1] + "' where id = '" + count + "'", sqlcon);
                        DataTable dtbl1 = new DataTable();
                        sqlmale1.Fill(dtbl1);
                        count++;
                        if (Convert.ToString(values[temp]) == "X")
                        {
                            break;
                        }
                    }
                }
            }

            /*

            for (int i = 0; i < values.Length; i++)
            {

                if (values[i] == String.Empty)
                {
                    continue;
                }
                else if (Convert.ToString(values[i]) == "ISA")
                {
                    for (int temp = i; temp < 5; temp++)
                    {
                        SqlConnection sqlcon = new SqlConnection(@"Data Source=EFCYIT-LTR910;Initial Catalog=product; Integrated Security=True");
                        SqlDataAdapter sqlmale = new SqlDataAdapter("insert into EDI(ISA) values('" + values[temp + 1] + "')", sqlcon);
                        DataTable dtbl = new DataTable();
                        sqlmale.Fill(dtbl);
                    }
                }
                else if (Convert.ToString(values[i]) == "GS")
                {
                    for (int temp = i; temp < 5; temp++)
                    {
                        SqlConnection sqlcon = new SqlConnection(@"Data Source=EFCYIT-LTR910;Initial Catalog=product; Integrated Security=True");
                        SqlDataAdapter sqlmale = new SqlDataAdapter("insert into EDI(GS) values('" + values[temp + 1] + "')", sqlcon);
                        DataTable dtbl = new DataTable();
                        sqlmale.Fill(dtbl);
                        if (Convert.ToString(values[i]) == "GS")
                        {
                            break;
                        }
                    }
                }
            }
            */
        
        }
    }
}
