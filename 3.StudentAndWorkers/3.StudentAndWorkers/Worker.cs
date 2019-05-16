using System;
using System.Collections.Generic;
using System.Text;


namespace _3.StudentAndWorkers
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, double weekSalary, double workHoursperDay) : base(firstName, lastName
            )
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = WorkHoursPerDay;
        }

        public double WeekSalary { get; set; }

        public double WorkHoursPerDay { get; set; }

        
        
        public double MoneyPerHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * 5);
        }

    }
}
