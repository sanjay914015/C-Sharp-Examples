using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Day_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String path = @"C:\C Sharp\C-Sharp-Examples\Day 6\Day 6\test.txt";

            System.IO.StreamReader reader;
            reader = new System.IO.StreamReader(path);
            string Data = reader.ReadToEnd();
            reader.Close();

            string[] values = Data.Split('*','>','~');
            try
            {
                for(int i = 0; i < values.Length; i++)
                {
                    Console.WriteLine(values[i]);
                }
            }
            catch
            {
                Console.WriteLine("No More Data Available !!!");
            }
        }
    }
}
