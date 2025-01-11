using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Emit;
using System.Security.Claims;
using System.Security.Cryptography;

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


            HiringDate hireDatex = new HiringDate(2, 2, 2022);

            Employees emp = new Employees(name: "Mohamed", Gender.Male, 7000, Security_Level.Developer, hire_Date: hireDatex);
            Console.WriteLine(emp);


            #endregion
            


        }
    }
}
