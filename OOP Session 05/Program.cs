using System;

namespace OOP_Session_05
{
    #region First Project 
    class Point3D
    {
        public int x, y, z;


        public Point3D()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        public Point3D(int xValue, int yValue, int zValue)
        {
            x = xValue;
            y = yValue;
            z = zValue;
        }


        public override string ToString()
        {
            return "Point Coordinates: (" + x + ", " + y + ", " + z + ")";
        }


        public bool IsEqual(Point3D other)
        {
            return x == other.x && y == other.y && z == other.z;
        }


        public Point3D Clone()
        {
            return new Point3D(x, y, z);
        }

        
    }
    #endregion

    #region Second Project
    class Maths
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                return 0;
            }
            return (double)a / b;
        }
    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Point3D p1 = ReadPointFromUser("P1");
            Point3D p2 = ReadPointFromUser("P2");

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());


            if (p1.IsEqual(p2))
            {
                Console.WriteLine("P1 is equal to P2");
            }
            else
            {
                Console.WriteLine("P1 is NOT equal to P2");
            }


            Point3D[] points = new Point3D[3];
            points[0] = new Point3D(5, 2, 1);
            points[1] = new Point3D(3, 3, 2);
            points[2] = new Point3D(1, 4, 3);

            for (int i = 0; i < points.Length - 1; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    if (points[i].x > points[j].x ||
                        (points[i].x == points[j].x && points[i].y > points[j].y))
                    {
                        
                        Point3D temp = points[i];
                        points[i] = points[j];
                        points[j] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted Points:");
            foreach (Point3D pt in points)
            {
                Console.WriteLine(pt.ToString());
            }

           
            Point3D cloned = p1.Clone();
            Console.WriteLine("Cloned Point: " + cloned.ToString());

            #region Second Project
            int a = 10;
            int b = 5;

            Console.WriteLine("Add: " + Maths.Add(a, b));
            Console.WriteLine("Subtract: " + Maths.Subtract(a, b));
            Console.WriteLine("Multiply: " + Maths.Multiply(a, b));
            Console.WriteLine("Divide: " + Maths.Divide(a, b));
            #endregion

        }
        #region First Project 
        static Point3D ReadPointFromUser(string pointName)
        {
            int x, y, z;

            Console.WriteLine("Enter values for " + pointName);

            Console.Write("X: ");
            while (!int.TryParse(Console.ReadLine(), out x))
                Console.Write("Please enter a valid number: ");

            Console.Write("Y: ");
            while (!int.TryParse(Console.ReadLine(), out y))
                Console.Write("Please enter a valid number: ");

            Console.Write("Z: ");
            while (!int.TryParse(Console.ReadLine(), out z))
                Console.Write("Please enter a valid number: ");

            return new Point3D(x, y, z);
        }
        #endregion

    }
}

