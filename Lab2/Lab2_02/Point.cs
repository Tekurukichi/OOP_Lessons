namespace Lab2_02
{
    public class Point
    {
        public double X { get; }
        public double Y { get; }
        public string Name { get; }

        public Point(double x, double y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }
    }
}