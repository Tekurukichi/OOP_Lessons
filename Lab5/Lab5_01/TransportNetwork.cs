using System;
using System.Collections.Generic;

namespace Lab5_01
{
    public class TransportNetwork
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void ControlMovement()
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.Move();
            }
        }
    }
}