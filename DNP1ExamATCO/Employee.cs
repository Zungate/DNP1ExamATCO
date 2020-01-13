using System;
using System.Collections.Generic;

namespace AtcoDataLibrary
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public Dictionary<DateTime, double> HoursWorked { get; set; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
            HoursWorked = new Dictionary<DateTime, double>();
        }

        public abstract double GetHours(DateTime dt);

        override public string ToString()
        {
            return $"Id: {Id}, name: {Name}";
        }
    }
}
