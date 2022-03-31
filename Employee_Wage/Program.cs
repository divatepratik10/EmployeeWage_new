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

            const int EMP_PRESENT = 1, EMP_PART_TIME = 2;// EMP_ABSENT = 0;
            Random random = new Random();
            int empinput = random.Next(0, 3);
            int EMP_HOUR;
            int WAGE_PERHOUR = 20;
            int DAILY_WAGE;

            switch (empinput)
            {
                case EMP_PRESENT:
                    Console.WriteLine("Employee is Fulltime Present.");
                    EMP_HOUR = 8;
                    break;
                case EMP_PART_TIME:
                    Console.WriteLine("Employee is Part-Time present.");
                    EMP_HOUR = 4;
                    break;
                default:
                    Console.WriteLine("Employee is Absent.");
                    EMP_HOUR = 0;
                    break;
            }

            DAILY_WAGE = EMP_HOUR * WAGE_PERHOUR;
            Console.WriteLine("Daily wage of Employee is Rs. {0}",DAILY_WAGE);
            Console.ReadLine();
        }
    }
}
