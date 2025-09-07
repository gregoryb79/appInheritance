using System;

namespace com.hr
{
    class Employee : IComparable<Employee>
    {
        public string Firstname
        { get; set; }
        public string Lastname
        { get; set; }

        public decimal Salary
        { get; set; }

        public int CompareTo(Employee obj)
        {
            if (obj == null) return 1;
            return this.Salary.CompareTo(obj.Salary);
        }
    }
}