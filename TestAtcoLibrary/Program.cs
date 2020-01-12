using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtcoDataLibrary;

namespace TestAtcoLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var ATC = new ATCCenter();

            string[] names = { "Kenneth", "Morten", "Armin", "Emil", "Christian" };

            var count = 1;
            Random random = new Random();
            DateTime dt = DateTime.Parse($"2019-04-30");

            foreach (var item in names)
            {
                var atco = new ATCO(count, count, item);
                ATC.AddEmployee(atco);
                Console.WriteLine($"Adding employee: {item}");

               
                atco.RegisterHours(random.NextDouble() * 12, dt);
                count++;

                
            }

            Console.ReadLine();

            Console.WriteLine("Printing all ATCOs");
            
            foreach(var empl in ATC.GetEmployees())
            {
                Console.WriteLine($"{empl.ToString()} has worked {empl.HoursWorked[dt]} hours on {dt}");
               
            }
            Console.WriteLine($"Total hours on {dt}: {ATC.GetAllHours(dt)} ");
            Console.ReadLine();
        }
    }
}
