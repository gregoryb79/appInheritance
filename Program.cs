using System;
using com.hr;
using System.Collections.Generic;

namespace CSClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager
            {
                Firstname = "Greg",
                Lastname = "Low",
                Salary = 50000,
                Filename = "Employees.csv"
            };

            foreach (Employee e in m.Employees)
            {
                Console.WriteLine($"{e.Firstname} {e.Lastname} {e.Salary}");
            }

            List<Car> cars = new List<Car>();

            for (int i = 0; i < 32; i++)
            {
                cars.Add(new Car { ID = i, Assigned = false });
            }

            int idx = new Random().Next(cars.Count);
            m.CompanyCar = cars[idx];
            cars[idx].Assigned = true;
            Console.WriteLine($"Manager {m.Firstname} {m.Lastname} has car ID {m.CompanyCar.ID}");
            Console.WriteLine(m);
        }
        
    }
}
