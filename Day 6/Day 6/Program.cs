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
            String path = @"C:\Users\Lenovo\Desktop\test.txt";

            System.IO.StreamReader reader;
            reader = new System.IO.StreamReader(path);
            string Data = reader.ReadToEnd();
            reader.Close();
            List<string> ISA = new List<string>();
            List<string> GS = new List<string>();
            string[] values = Data.Split('~');
            for(int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
        }
    }
}
