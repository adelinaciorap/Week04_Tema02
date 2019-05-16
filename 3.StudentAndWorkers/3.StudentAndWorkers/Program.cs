using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.StudentAndWorkers
{
    class Program
    {
        static void SortStudentByGrade(List<Student> studentsList)
        {
            var sortedList =
                from stud in studentsList
                orderby stud.Grade ascending
                select stud;

            // Print sorted students
            Console.WriteLine("---------- STUDENTS ----------");
            foreach (var element in sortedList)
            {
                Console.WriteLine("Full name: {0}, Grade: {1}", element.FirstName + " " + element.LastName, element.Grade);
            }

            Console.WriteLine();
        }


        static void SortWorkersByMoneyPerHours(List<Worker> workersList)
        {
            var sortedList = workersList.OrderByDescending(x => x.MoneyPerHour());

            // Print workers
            Console.WriteLine("---------- WORKERS ----------");
            foreach (var element in sortedList)
            {
                Console.WriteLine("Full name: {0}", element.FirstName + " " + element.LastName);
                Console.WriteLine("Week salary: " + element.WeekSalary);
                Console.WriteLine("Work hours per day: " + element.WorkHoursPerDay);
                Console.WriteLine("Money per hours: " + element.MoneyPerHour());
                Console.WriteLine();
            }
        }

        static void SortMergedList(List<Human> mergedList)
        {
            var sortedList =
                from merge in mergedList
                orderby merge.FirstName, merge.LastName
                select merge;

            // Print merged list
            Console.WriteLine("---------- MERGED LIST ----------");
            foreach (var element in sortedList)
            {
                Console.WriteLine("First name: {0}, Last name: {1}", element.FirstName, element.LastName);
            }
        }

        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>() {

            new Student("Ioan", "Ioan", 8.5m),
            new Student("Paul", "Stefani", 5.8m),
            new Student("Stefan", "Petrils", 9.9m),
            new Student("ANa", "Slava", 10),
            new Student("Dan", "Panu", 6.7m),
            new Student("Tatiana", "Abced", 7.9m),
            new Student("Maria", "Ioana", 8.45m),
            new Student("Cristina", "Cretu", 7.78m),
            new Student("Ilie", "Balan", 9.5m),
            new Student("Radu", "Parvu", 9.11m),

            };

            
            List<Worker> workerList = new List<Worker>()
            {
               
            new Worker("Oana", "Gruia", 80.5, 8),
            new Worker("Dana", "Cascaval", 445.8, 6),
            new Worker("Vasile;", "Bibi", 245.90, 7),
            new Worker("Erika", "Cineva", 300.7, 9),
            new Worker("Irina", "Ceva", 150.9, 10),
            new Worker("Nadia", "Penes", 700.5, 12),
            new Worker("Eva", "Gghita", 220.78, 8),
            new Worker("Stan", "Soian", 100.1, 4),
            new Worker("Costi", "Mihai", 356.7, 7),
            new Worker("Idan", "Grama", 1000, 6),

            };

            SortStudentByGrade(studentList);
            SortWorkersByMoneyPerHours(workerList);

            List<Human> mergeList = new List<Human>();
            mergeList.AddRange(studentList);
            mergeList.AddRange(workerList);

            SortMergedList(mergeList);
            


        }
    }
}
    
