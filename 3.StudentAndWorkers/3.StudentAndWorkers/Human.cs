using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.StudentAndWorkers
{
    public abstract  class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
      }


}
