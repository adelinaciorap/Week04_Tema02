using System;
using System.Collections.Generic;
using System.Text;


namespace _3.StudentAndWorkers
{
    public class Student : Human
    {
        private decimal grade;
        
        public decimal Grade
        {
            get { return this.grade; }
            set { grade = value; }

        }
         public Student(string firstName, string lastName, decimal grade):base(firstName, lastName)
        {
            this.Grade = grade;
        }
    }


}
