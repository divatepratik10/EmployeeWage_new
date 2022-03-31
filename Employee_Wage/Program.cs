﻿using System;
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

            const int EMP_PRESENT = 1, PART_PRESENT = 2; //EMP_ABSENT = 0;
            int EMP_RATEper_HOUR = 20;
            int NUMBERofWORKING_DAYS = 20;
            int MAX_WORKING_HOURS = 100;
            int EMP_HOURS = 0;
            int EMP_WAGE = 0;
            int TOTAL_EMP_WAGE = 0;
            int WORKING_HOURS = 0;
            int day = 1;
            Random random = new Random();

            while (day<=NUMBERofWORKING_DAYS && EMP_HOURS <= MAX_WORKING_HOURS)
            {
                int EMP_INPUT = random.Next(0, 3);

                switch (EMP_INPUT)
                {
                    case EMP_PRESENT:
                        Console.WriteLine("Employee is Fulltime Present.");
                        EMP_HOURS = 8;
                        break;
                    case PART_PRESENT:
                        Console.WriteLine("Employee is Part-Time present.");
                        EMP_HOURS = 4;
                        break;
                    default :
                        Console.WriteLine("Employee is Absent.");
                        EMP_HOURS = 0;
                        break;
                    
                }


                EMP_WAGE = EMP_RATEper_HOUR * EMP_HOURS;
                Console.WriteLine("Daily Employee Wage for day{0} is Rs. {1}", day, EMP_WAGE);
                TOTAL_EMP_WAGE += EMP_WAGE;
                WORKING_HOURS += EMP_HOURS;
                day++;

            }
            Console.WriteLine("Total Employee wage for {0} days and Working hours {1} is Rs. {2}", day-1, WORKING_HOURS, TOTAL_EMP_WAGE);
            Console.ReadLine();

        }
    }
}
