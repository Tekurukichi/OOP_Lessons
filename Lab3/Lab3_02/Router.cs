namespace Lab3_02
{
    public class Router:Computer
    {
        public int MaxInterfaces { get; set; }

        public Router(string ipAddress, int power, string osType, int maxInterfaces)
            : base(ipAddress, power, osType)
        {
            MaxInterfaces = maxInterfaces;
        }
    }
}