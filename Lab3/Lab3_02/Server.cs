using System;
using System.Data;
using Lab3_02.Interface;

namespace Lab3_02
{
    public class Server : Computer
    {
        public int MaxConnections { get; set; }

        public Server(string ipAddress, int power, string osType, int maxConnections)
            : base(ipAddress, power, osType)
        {
            MaxConnections = maxConnections;
        }
    }
}
    
