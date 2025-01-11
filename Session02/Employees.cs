using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02
{
    enum Gender
    {
        M = 1, F = 2, Male = 1, Famale = 2
    }
    enum Security_Level
    {
        guest, Developer, secretary , DBA
    }
    internal class Employees
    {
        
        public string Name;
        public Security_Level Security_Level;
        public decimal Salary;
        public HiringDate Hire_Date;
        public Gender Gender;

        public Employees(string name,Gender gender  , decimal salary, Security_Level security_Level, HiringDate hire_Date )
        {
            Name = name;
            Gender = gender;
            Salary = salary;
            Security_Level = security_Level;
            Hire_Date = hire_Date;
        }

        public override string ToString()
        {
            return $"Name : {Name}\nSalary: {Salary}\nSecurity_Level : {Security_Level}\nDate : {Hire_Date.ToString()}\nGender : {Gender}";
        }
    }
}
