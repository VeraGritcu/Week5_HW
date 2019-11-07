using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    internal class Worker : Human
    {
        public Worker(string fn, string ln, double ws, double whpd): base(fn,ln)
        {
            this.WeekSalary = ws;
            this.WorkHoursPerDay = whpd;
        }
        internal double WeekSalary { get; set; }
        internal double WorkHoursPerDay { get; set; }
        internal double MoneyPerHour()
        {
            return WeekSalary / (WorkHoursPerDay * 5);
        }
    }
}
