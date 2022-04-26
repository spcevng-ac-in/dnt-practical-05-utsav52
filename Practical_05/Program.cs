using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practical_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write whatever you would like to:");
            string text = Console.ReadLine();
            File.WriteAllText("file.txt", text);
            try
            {
                string entereddata = File.ReadAllText("file.txt");
                Console.WriteLine(entereddata);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
