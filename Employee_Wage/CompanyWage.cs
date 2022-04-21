using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    internal class CompanyWage:Object
    {
        public string Company;
        public int NUMBERofWORKING_DAYS, EMP_RATEper_HOUR, MAX_WORKING_HOURS, TOTAL_WAGE = 0;

        public CompanyWage(string Company, int NUMBERofWORKING_DAYS, int EMP_RATEper_HOUR, int MAX_WORKING_HOURS)
        {
            this.Company = Company;
            this.NUMBERofWORKING_DAYS = NUMBERofWORKING_DAYS;
            this.EMP_RATEper_HOUR = EMP_RATEper_HOUR;
            this.MAX_WORKING_HOURS = MAX_WORKING_HOURS;
        }

        public override string ToString()
        {
            return "Company : "+Company+" Total Wage : "+TOTAL_WAGE;
        }

        public void SetTotalWage(int TOTAL_WAGE)
        {
            this.TOTAL_WAGE = TOTAL_WAGE;
        }

    }
}
