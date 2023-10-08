using System;
using Lab3_02.Interface;

namespace Lab3_02
{
    public class Workstation : Computer
    {
        public bool IsMobile { get; set; }

        public Workstation(string ipAddress, int power, string osType, bool isMobile)
            : base(ipAddress, power, osType)
        {
            IsMobile = isMobile;
        }
    }
}