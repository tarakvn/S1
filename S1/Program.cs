using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Your number is: " + N);
            Console.ReadKey();
        }
    }
}
