using System;

namespace Lab3_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server("192.168.1.1", 1000, "Windows Server", 50);
            Workstation workstation = new Workstation("192.168.1.2", 500, "Windows 10", true);
            Router router = new Router("192.168.1.3", 200, "RouterOS", 4);

            
            Network network = new Network();
            
            network.Connect(server);
            network.Connect(workstation);
            network.Connect(router);
            
            network.TransferData(workstation, server, "Sample data");
            
            network.Disconnect(workstation);
            
            network.TransferData(workstation, server, "Another data");

            Console.ReadLine();
        }
    }
}