using System;
using System.Collections.Generic;
using Lab3_02.Interface;

namespace Lab3_02
{
    public class Network: IConnectable
    {
        private List<Computer> devices = new List<Computer>();

        public void Connect(Computer device)
        {
            if (!devices.Contains(device))
            {
                devices.Add(device);
                Console.WriteLine($"Connected {device.IPAddress} to the network.");
            }
        }

        public void Disconnect(Computer device)
        {
            if (devices.Contains(device))
            {
                devices.Remove(device);
                Console.WriteLine($"Disconnected {device.IPAddress} from the network.");
            }
        }

        public void TransferData(Computer source, Computer destination, string data)
        {
            if (devices.Contains(source) && devices.Contains(destination))
            {
                Console.WriteLine($"Transferring data from {source.IPAddress} to {destination.IPAddress}: {data}");
            }
            else
            {
                Console.WriteLine("Data transfer failed. Source or destination not connected to the network.");
            }
            }
        
    }
}