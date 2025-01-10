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

            Console.WriteLine("Enter the details of person 1:");
            Console.Write("Name: ");
            string name1 = Console.ReadLine();
            Console.Write("Age: ");
            int age1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the details of person 2:");
            Console.Write("Name: ");
            string name2 = Console.ReadLine();
            Console.Write("Age: ");
            int age2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the details of person 3:");
            Console.Write("Name: ");
            string name3 = Console.ReadLine();
            Console.Write("Age: ");
            int age3 = int.Parse(Console.ReadLine());


            Person p1 = new Person(name1, age1);
            Person p2 = new Person(name2, age2);
            Person p3 = new Person(name3, age3);

            if (p1.Age > p2.Age & p1.Age > p3.Age)
            {
                Console.WriteLine(p1);
            }
            else if(p2.Age > p1.Age & p2.Age > p3.Age)
            {
                Console.WriteLine(p2);
            }
            else if (p3.Age > p1.Age & p3.Age > p3.Age)
            {
                Console.WriteLine(p3);
            }

            #endregion
        }
    }
}
