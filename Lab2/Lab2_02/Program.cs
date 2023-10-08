using System;

namespace Lab2_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(0, 0, "A");
            Point point2 = new Point(4, 0, "B");
            Point point3 = new Point(0, 3, "C");

            Figure triangle = new Figure(point1, point2, point3);
            triangle.CalculatePerimeter();

            Point point4 = new Point(0, 0, "A");
            Point point5 = new Point(4, 0, "B");
            Point point6 = new Point(4, 3, "C");
            Point point7 = new Point(0, 3, "D");

            Figure quadrilateral = new Figure(point4, point5, point6, point7);
            quadrilateral.CalculatePerimeter();

            
        }
    }
}