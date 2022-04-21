using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    internal class EMPwageCompute
    {
        public CompanyWage[] companies = new CompanyWage[5];
        int NOofCOMPANIES = 0;

        public void AddComanies(string Company, int NUMBERofWORKING_DAYS, int EMP_RATEper_HOUR, int MAX_WORKING_HOURS)
        {
            companies[NOofCOMPANIES] = new CompanyWage(Company,NUMBERofWORKING_DAYS,EMP_RATEper_HOUR,MAX_WORKING_HOURS);
            NOofCOMPANIES++;    
        }

        public void ITTERATEoverCOMPANIES()
        {
            for(int i = 0; i < NOofCOMPANIES; i++)
            {
                int TOTAL_WAGE = ComputeWage(companies[i]);
                companies[i].SetTotalWage(TOTAL_WAGE);
            }
        }
        
            public int ComputeWage(CompanyWage Comp)
            {
                Console.WriteLine("Welcome to Employee wage programm.");

                const int EMP_PRESENT = 1, PART_PRESENT = 2; //EMP_ABSENT = 0;
                int EMP_HOURS = 0;
                int EMP_WAGE = 0;
                int TOTAL_EMP_WAGE = 0;
                int WORKING_HOURS = 0;
                int day = 1;
                Random random = new Random();

                while (day <= Comp.NUMBERofWORKING_DAYS && EMP_HOURS <= Comp.MAX_WORKING_HOURS)
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
                        default:
                            Console.WriteLine("Employee is Absent.");
                            EMP_HOURS = 0;
                            break;
                    }

                    EMP_WAGE = Comp.EMP_RATEper_HOUR * EMP_HOURS;
                    //Console.WriteLine("Daily Employee Wage of {2} for day{0} is Rs. {1}", day, EMP_WAGE, Comp.Company);
                    TOTAL_EMP_WAGE += EMP_WAGE;
                    WORKING_HOURS += EMP_HOURS;
                    if(WORKING_HOURS > Comp.NUMBERofWORKING_DAYS)
                    {
                        WORKING_HOURS -= EMP_HOURS;
                        break;
                    }
                    day++;

                }
                Console.WriteLine("Total Employee wage of {3} for {0} days and Working hours {1} is Rs. {2}", day - 1, WORKING_HOURS, TOTAL_EMP_WAGE,Comp.Company);
            //Console.ReadLine();
            return TOTAL_EMP_WAGE;
            }
        static void Main(string[] args)
        {
            EMPwageCompute wage = new EMPwageCompute();
            wage.AddComanies("BridgeLabz", 20, 30, 60);
            wage.AddComanies("Infosys",30,25,50);
            wage.AddComanies("Zensar",25,20,100);
            wage.ITTERATEoverCOMPANIES();
            Console.ReadLine();
        }

    }
}
