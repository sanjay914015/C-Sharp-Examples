using System; 
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_18_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=EFCYIT-LTR910;Initial Catalog=product; Integrated Security=True");

            while (true)
            {

                Console.WriteLine("1. Add Product \n2. sell product\n3. AVG\n4. Update Product\n5. Exit ");
                int asw = Convert.ToInt32(Console.ReadLine());
                if(asw == 1)
                {
                    Console.WriteLine("Enter Product Name : ");
                    string productname = Console.ReadLine();

                    Console.WriteLine("Enter Product Type: ");
                    string producttype = Console.ReadLine();

                    SqlDataAdapter sql1 = new SqlDataAdapter("select product_name from products", sqlcon);
                    DataTable dtbl1 = new DataTable();
                    sql1.Fill(dtbl1);
                    Console.ReadLine();
                    int flag = 0;
                    foreach (DataRow dataRow in dtbl1.Rows)
                    {
                        if (productname == Convert.ToString(dataRow["product_name"]))
                        {
                            Console.WriteLine("Product Name is Already Exists");
                            flag = 1;
                        }
                    }
                    if (flag == 1)
                    {
                        continue;
                    }

                    Console.WriteLine("Enter Product Quantity : ");
                    int productquantity = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Product Price : ");
                    int price = Convert.ToInt32(Console.ReadLine());


                    SqlDataAdapter sqlmale = new SqlDataAdapter("insert into products(product_name, product_type, product_q, price) values('" + productname + "', '" + producttype + "', '" + productquantity + "', '"+ price +"')", sqlcon);
                    DataTable dtbl = new DataTable();
                    sqlmale.Fill(dtbl);
                    Console.ReadLine();

                    Console.WriteLine("<----------------------Data Inserted Successfully ------------->");

                    continue;

                }
                else if(asw == 2)
                {
                    SqlDataAdapter sql1 = new SqlDataAdapter("select * from products", sqlcon);
                    DataTable dtbl1 = new DataTable();
                    sql1.Fill(dtbl1);
                    foreach (DataRow dataRow in dtbl1.Rows)
                    {
                        Console.WriteLine(dataRow["id"] + "   " + dataRow["product_name"] + "   " + dataRow["product_type"] + "   " + dataRow["product_q"] + "   ");
                    }

                    Console.WriteLine("Enter Which product id you want to enter sell data :");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Sell Quantity in KG for Week1:");
                    int week1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Sell Quantity in KG for Week2:");
                    int week2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Sell Quantity in KG for Week3:");
                    int week3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Sell Quantity in KG for Week4:");
                    int week4 = Convert.ToInt32(Console.ReadLine());

                    SqlDataAdapter sql2 = new SqlDataAdapter("select * from products", sqlcon);
                    DataTable dtbl2 = new DataTable();
                    sql1.Fill(dtbl1);
                    foreach (DataRow dataRow in dtbl1.Rows)
                    {
                        if (id == Convert.ToInt32(dataRow["id"]))
                        {
                            int temp = Convert.ToInt32(dataRow["product_q"]);
                            int total = week1 + week2 + week3 + week4;
                            float avg = total / 4;
                            temp = temp - total;
                            SqlDataAdapter sqlmale = new SqlDataAdapter("update products set product_q = '"+ temp + "',week1 = '" + week1 + "',week2 = '" + week2 + "',week3 = '" + week3 + "',week4 = '" + week4 + "', avgsell = '" + avg +"' where id = ('"+ id +"')" , sqlcon);
                            DataTable dtbl = new DataTable();
                            sqlmale.Fill(dtbl);
                            Console.ReadLine();
                        }
                    }

                    Console.WriteLine("<----------------------Product Sell Successfully ------------->");

                }
                else if(asw == 3)
                {
                    SqlDataAdapter sql1 = new SqlDataAdapter("select AVG(avgsell) as avg from products", sqlcon);
                    DataTable dtbl1 = new DataTable();
                    sql1.Fill(dtbl1);
                    Console.WriteLine("< ----------------------Avg Sell in 4 Week ------------->");
                    foreach(DataRow dataRow in dtbl1.Rows)
                    {
                        Console.WriteLine(dataRow["avg"]);
                    }
                    continue;
                }
                else if(asw ==4)
                {
                    Console.WriteLine("<----------Product Data------------>");
                    SqlDataAdapter sql1 = new SqlDataAdapter("select * from products", sqlcon);
                    DataTable dtbl1 = new DataTable();
                    sql1.Fill(dtbl1);
                    foreach (DataRow dataRow in dtbl1.Rows)
                    {
                        Console.WriteLine(dataRow["id"] + "   " + dataRow["product_name"] + "   " + dataRow["product_type"] + "   " + dataRow["product_q"] + "   "+dataRow["price"]);
                    }
                    int flag = 0;
                    Console.WriteLine("Enter ID Which you want Update::");
                    int id = Convert.ToInt32(Console.ReadLine());
                    foreach (DataRow dataRow in dtbl1.Rows)
                    {
                        if(id == Convert.ToInt32(dataRow["id"]))
                        {
                            Console.Write("name\ntype\nquantity\nprice");
                            string aswer = Console.ReadLine();
                            switch(aswer)
                            {
                                case "name":
                                    Console.WriteLine("Enter Product Name:");
                                    string name = Console.ReadLine();
                                    SqlDataAdapter sqlmale = new SqlDataAdapter("update products set product_name = '" + name + "' where id = ('" + id + "')", sqlcon);
                                    DataTable dtbl = new DataTable();
                                    sqlmale.Fill(dtbl);
                                    Console.ReadLine();
                                    break;
                                case "type":
                                    Console.WriteLine("Enter Product Name:");
                                    string type = Console.ReadLine();
                                    SqlDataAdapter sqlmale1 = new SqlDataAdapter("update products set product_type = '" + type + "' where id = ('" + id + "')", sqlcon);
                                    DataTable dtbl2 = new DataTable();
                                    sqlmale1.Fill(dtbl2);
                                    Console.ReadLine();
                                    break;
                                case "quantity":
                                    Console.WriteLine("Enter Product Quantity:");
                                    int quantity=Convert.ToInt32(Console.ReadLine());
                                    SqlDataAdapter sqlmale2 = new SqlDataAdapter("update products set product_q = '" + quantity + "' where id = ('" + id + "')", sqlcon);
                                    DataTable dtbl3 = new DataTable();
                                    sqlmale2.Fill(dtbl3);
                                    Console.ReadLine();
                                    break;
                                case "price":
                                    Console.WriteLine("Enter Product Name:");
                                    int price= Convert.ToInt32(Console.ReadLine());
                                    SqlDataAdapter sqlmale3 = new SqlDataAdapter("update products set price = '" + price + "' where id = ('" + id + "')", sqlcon);
                                    DataTable dtbl4 = new DataTable();
                                    sqlmale3.Fill(dtbl4);
                                    Console.ReadLine();
                                    break;
                                default:
                                    break;

                            }

                        }
                        else
                        {
                            Console.WriteLine("Entered ID doesn't exists");
                            flag = 1;
                        }
                    }
                    if(flag == 1)
                    {
                        continue;
                    }


                }
                else if(asw ==5)
                {
                    break;
                }
                else
                {
                    continue;
                }
                
            }

        }
    }
}
