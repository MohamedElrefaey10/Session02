using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02.Encapsulation
{
    internal struct Employee
    {
        #region Attributes
        public int Id;
        private string? Name;
        private decimal salary;

        #endregion

        #region Constructors
        public Employee(int id, string name, decimal _salary)
        {
            Id = id;
            Name = name;
            gSalary = _salary;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Id : {Id}\nName : {Name}\nSalary : {salary:c}";
        }
        #endregion
        #region Getter - setter

        public string? GetName()
        {
            return Name;
        }
        public void SetName(string? name)
        {
            this.Name = name?.Length > 5?name.Substring(0,5):name;
        }

        #endregion

        #region Propirty

        public decimal gSalary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value > 5000 ? 5000 : value;
            }
        }

        //private int age;

        //public int Age
        //{
        //    get
        //    { return age; }
        //    set
        //    { age = value; }
        //}

        public int Age { get; set; }

        //private decimal deduction;

        public decimal Deduction
        {
            get { return gSalary * 0.2m; }
        }

        #endregion
    }
    }