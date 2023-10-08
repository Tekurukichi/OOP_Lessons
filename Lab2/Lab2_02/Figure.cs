using System;
using System.Collections.Generic;

namespace Lab2_02
{
    public class Figure
    {
        private List<Point> points;

        public Figure(Point point1, Point point2, Point point3)
        {
            points = new List<Point> { point1, point2, point3 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            points = new List<Point> { point1, point2, point3, point4 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            points = new List<Point> { point1, point2, point3, point4, point5 };
        }

        private double GetDistance(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }

        public double GetSideLength(Point a, Point b)
        {
            return GetDistance(a, b);
        }

        public void CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Count; i++)
            {
                int nextIndex = (i + 1) % points.Count;
                perimeter += GetSideLength(points[i], points[nextIndex]);
            }

            Console.WriteLine($"Назва багатокутника: {points.Count}-кут");
            Console.WriteLine($"Периметр багатокутника: {perimeter}");
        }
    }
}