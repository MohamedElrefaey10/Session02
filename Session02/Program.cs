namespace Session02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            Console.WriteLine("aaaEnter X1 Y1 ");
            var input1 = Console.ReadLine().Split();
            double x1 = double.Parse(input1[0]);
            double y1 = double.Parse(input1[1]);

            Console.WriteLine("Enter X Y2 ");
            var input2 = Console.ReadLine().Split();
            double x2 = double.Parse(input2[0]);
            double y2 = double.Parse(input2[1]);
            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);

            double zz = Point.xxx(p1, p2);
            Console.WriteLine(zz);
        } 
        #endregion
    }
}
