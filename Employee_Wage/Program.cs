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
            int EMP_HOUR;
            int WAGE_PERHOUR = 20;
            int DAILY_WAGE;

            if (empinput == EMP_PRESENT)
            {
                Console.WriteLine("Employee is Present.");
                EMP_HOUR = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent.");
                EMP_HOUR = 0;
            }

            DAILY_WAGE = EMP_HOUR * WAGE_PERHOUR;
            Console.WriteLine("Daily wage of Employee is Rs. {0}",DAILY_WAGE);
            Console.ReadLine();
        }
    }
}
