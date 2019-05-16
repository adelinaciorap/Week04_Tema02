using System;
using System.Collections.Generic;
using System.Text;


namespace _3.StudentAndWorkers
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, double weekSalary, int workHoursperDay) : base(firstName, lastName
            )
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursperDay;
        }

        public double WeekSalary { get; set; }

        public int WorkHoursPerDay { get; set; }

        
        
        public double MoneyPerHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * 5);
        }

    }
}
