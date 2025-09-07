using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace com.hr
{
    class Manager : Employee
    {
        private string filename;
        public List<Employee> Employees
        { get; set; }

        public string Filename
        {
            get { return filename; }
            set
            {
                filename = value;
                this.Employees = File.ReadAllLines(value)
                    .Skip(1)
                    .Select(null)
                    .ToList();               
            }
        }
    }
}