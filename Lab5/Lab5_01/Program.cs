using System;

namespace Lab5_01
{
    class Program
    {
        static void Main(string[] args)
        {
            TransportNetwork network = new TransportNetwork();

            Car car = new Car();
            Bus bus = new Bus();
            Train train = new Train();

            network.AddVehicle(car);
            network.AddVehicle(bus);
            network.AddVehicle(train);

            network.ControlMovement();

            Route route = new Route("City A", "City B");
            string carRoute = route.CalculateOptimalRoute(car);
            string busRoute = route.CalculateOptimalRoute(bus);
            string trainRoute = route.CalculateOptimalRoute(train);

            Console.WriteLine(carRoute);
            Console.WriteLine(busRoute);
            Console.WriteLine(trainRoute);
           
        }
    }
}