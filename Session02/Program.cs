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

            //Employee employee = new Employee(70, "Ali", 7000);

            //Console.WriteLine(employee);
            ////employee.Id = 100;

            ////Console.WriteLine(employee.Id);
            ////employee.SetName("Mohammed");
            ////Console.WriteLine(employee.GetName());

            //employee.gSalary = 6000;
            ////Console.WriteLine(employee.Salary);
            ////employee.Age = 20;
            ////Console.WriteLine(employee.Age);
            //Console.WriteLine(employee.Deduction);
            #endregion

            #region MyRegion

            PhoneBook Note = new PhoneBook(4);

            Note.AddPerson(1, "Ahmed", 123);
            Note.AddPerson(2, "Mona", 456);
            Note.AddPerson(3, "Ramiz", 789);

            //int numberr = Note.GetMumber("Monam");

            //Console.WriteLine(numberr == -1 ? "Not found": numberr); 

            Note.SetNumber("Ramiz", 555);
            Console.WriteLine(Note.GetMumber("Ramiz"));
            #endregion
        }
    }
}
