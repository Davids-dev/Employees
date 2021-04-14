using System;
using System.Collections.Generic;
using System.Globalization;
using CourseEmployes.Entities;
namespace CourseEmployes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int number = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char outsorced = char.Parse(Console.ReadLine());          
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hour = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsorced == 'y')
                {
                    Console.Write("Additional Charge: ");
                    double charge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutSourcedEmployee(charge, name, hour, value));
                }
                else
                {
                    list.Add(new Employee( name, hour, value));
                }             
            }

            Console.WriteLine();
            Console.WriteLine("Payments: ");
            foreach(Employee employee in list)
            {
                Console.WriteLine(employee.Name + " - $ " + employee.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
