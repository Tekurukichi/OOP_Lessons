using System;

namespace Lab5_01
{
    public class Route
    {
        public string StartPoint { get; private set; }
        public string EndPoint { get; private set; }

        public Route(string start, string end)
        {
            StartPoint = start;
            EndPoint = end;
        }

        public string CalculateOptimalRoute(Vehicle vehicle)
        {
            
            return $"Optimal route from {StartPoint} to {EndPoint} for {vehicle.GetType().Name}.";
        }
    }
}