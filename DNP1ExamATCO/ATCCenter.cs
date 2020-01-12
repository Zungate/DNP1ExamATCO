using System;
using System.Collections.Generic;
using System.Text;

namespace AtcoDataLibrary
{
    public class ATCCenter
    {
        public List<Employee> Employees { get; set; }

        public ATCCenter()
        {
            Employees = new List<Employee>();

            string[] names = { "Kenneth", "Morten", "Armin", "Emil", "Christian" };

            var count = 1;
            Random random = new Random();
            DateTime dt = DateTime.Parse($"2019-04-30");

            foreach (var item in names)
            {
                var atco = new ATCO(count, count, item);
                AddEmployee(atco);
                Console.WriteLine($"Adding employee: {item}");


                atco.RegisterHours(random.NextDouble() * 12, dt);
                count++;
            }
        }

        public List<Employee> GetEmployees()
        {
            return Employees;
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public double GetAllHours(DateTime dt)
        {
            var hours = 0.0;
            foreach(var empl in Employees)
            {
                hours += empl.HoursWorked[dt];
            }

            return hours;
        }
    }
}
