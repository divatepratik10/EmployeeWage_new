using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage programm.");

            const int EMP_PRESENT = 1; // EMP_ABSENT = 0;
            Random random = new Random();
            int empinput = random.Next(0, 2);

            if (empinput == EMP_PRESENT)
                Console.WriteLine("Employee is Present.");
            else
                Console.WriteLine("Employee is absent.");

            Console.ReadLine();
        }
    }
}
