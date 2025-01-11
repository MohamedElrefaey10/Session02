using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Emit;
using System.Security.Claims;
using System.Security.Cryptography;
using static Session02.HiringDate;
using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace Session02
{
    internal class Program
    {
        static void Main(string[] args)
        {
        #region 1.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
        //Console.WriteLine("aaaEnter X1 Y1 ");
        //var input1 = Console.ReadLine().Split();
        //double x1 = double.Parse(input1[0]);
        //double y1 = double.Parse(input1[1]);

        //Console.WriteLine("Enter X Y2 ");
        //var input2 = Console.ReadLine().Split();
        //double x2 = double.Parse(input2[0]);
        //double y2 = double.Parse(input2[1]);
        //Point p1 = new Point(x1, y1);
        //Point p2 = new Point(x2, y2);

        //double zz = Point.xxx(p1, p2);
        //Console.WriteLine(zz);
        //Console.WriteLine();

        #endregion
        #region 2.Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

        //Console.WriteLine("Enter the details of person 1:");
        //Console.Write("Name: ");
        //string name1 = Console.ReadLine();
        //Console.Write("Age: ");
        //int age1 = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter the details of person 2:");
        //Console.Write("Name: ");
        //string name2 = Console.ReadLine();
        //Console.Write("Age: ");
        //int age2 = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter the details of person 3:");
        //Console.Write("Name: ");
        //string name3 = Console.ReadLine();
        //Console.Write("Age: ");
        //int age3 = int.Parse(Console.ReadLine());


        //Person p1 = new Person(name1, age1);
        //Person p2 = new Person(name2, age2);
        //Person p3 = new Person(name3, age3);


        //Person[] pX = { p1, p2, p3 };


        //Person oldestPerson = pX[0];

        //for (int i = 1; i < pX.Length; i++)
        //{
        //    if (pX[i].Age > oldestPerson.Age)
        //    {
        //        oldestPerson = pX[i];
        //    }
        //}

        //Console.WriteLine($"The oldest person is: {oldestPerson}");

        //if (p1.Age > p2.Age & p1.Age > p3.Age)
        //{
        //    Console.WriteLine(p1);
        //}
        //else if (p2.Age > p1.Age & p2.Age > p3.Age)
        //{
        //    Console.WriteLine(p2);
        //}
        //else if (p3.Age > p1.Age & p3.Age > p3.Age)
        //{
        //    Console.WriteLine(p3);
        //}


        #endregion
        #region Part 02 1.Design and implement a Class for the employees in a company: Notes: ●	Employee is identified by an ID, Name, security level, salary, hire date and Gender. ●	We need to restrict the Gender field to be only M or F[Male or Female] ●	Assign the following security privileges to the employee(guest, Developer, secretary and DBA) in a form of Enum. ●	We want to provide the Employee Class to represent Employee data in a string Form(override ToString()), display employee salary in a currency format. [Use String.Format() Function]. 0.	Develop a Class to represent the Hiring Date Data: ● Consisting of fields to hold the day, month and Years.


        //HiringDate hireDatex = new HiringDate(2, 2, 2022);

        //Employees emp = new Employees(name: "Mohamed", Gender.Male, 7000, SecurityLevel.Guest, hire_Date: hireDatex);
        //Console.WriteLine(emp);


        #endregion
        #region 0.Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;) Notes ● Implement All the Necessary Member Functions on the Class(Getters, Setters) ● Define all the Necessary Constructors for the Class ● Allow NO RUNTIME errors if the user inputs any data ● Write down all the necessary Properties(Instead of setters and getters)


            HiringDate hireDate1 = new HiringDate(2, 2, 2022);
            HiringDate hireDate2 = new HiringDate(2, 2, 2022);
            HiringDate hireDate3 = new HiringDate(2, 2, 2022);

            Employees emp1 = new Employees(name: "Mohamed", Gender.Male, 7000, SecurityLevel.Guest, hire_Date: hireDate1);
            Employees emp2 = new Employees(name: "Mohamed", Gender.Male, 7000, SecurityLevel.DBA, hire_Date: hireDate2);
            Employees emp3 = new Employees(name: "Mohamed", Gender.Male, 7000, SecurityLevel.SecurityOfficer, hire_Date: hireDate3);

            Employees[] EmpArr = new Employees[] { emp1, emp2, emp3 };

            // Printing out employee details
            foreach (var emp in EmpArr)
            {
                Console.WriteLine(emp.ToString());
            }
            #endregion


        }
    }
}
