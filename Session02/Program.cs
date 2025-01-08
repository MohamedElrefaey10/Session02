using Session02.Encapsulation;

namespace Session02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region intro To OOP

            // 1. Encapsulation
            // 2. inheritance
            // 3. polymorhism
            // 4. Abstraion

            #endregion

            #region Encapsulation
            //Employee employee1 = new Employee();
            //Console.WriteLine(employee1);
            //Console.WriteLine(employee1.ToString());

            Employee employee = new Employee(70, "Ali", 4000);

            Console.WriteLine(employee);
            //employee.Id = 100;

            //Console.WriteLine(employee.Id);
            //employee.SetName("Mohammed");
            //Console.WriteLine(employee.GetName());

            employee.Salary = 6000;
            Console.WriteLine(employee.Salary);
            employee.Age = 20;
            Console.WriteLine(employee.Age);
            Console.WriteLine(employee.Deduction);
            #endregion
        }
    }
}
