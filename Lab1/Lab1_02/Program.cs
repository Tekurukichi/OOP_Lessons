using System;

namespace Lab1_02
{
    
    internal class Program
    {
        
        public static void Main(string[] args)
        {

            Converter converter = InitConverter();
            MainOperation(converter);
        }

        private static Converter InitConverter()
        {

            double usd = Converter.GetDoubleInput("Input USD to UAH rate:");
            double eur = Converter.GetDoubleInput("Input EUR to UAH rate:");
            double pln = Converter.GetDoubleInput("Input PLN to UAH rate:");
            
            return new Converter(usd, eur, pln);
        }

        private static void MainOperation(Converter converter)
        {
            
            switch (Converter.GetIntInput("Select operation:\n 1 - Convertation form UAH\n 2 - Convertation to UAH\n 3 - Exit ", 1, 3))
            {
                case 1:
                    ConvertFromUAH(converter);
                    break;
                case 2:
                    ConvertToUAH(converter);
                    break;
                case 3:
                    return;
            }
            MainOperation(converter);
        }

        private static void ConvertFromUAH(Converter converter)
        {
            
            int currency = Converter.GetIntInput("Select currency:\n 1 - USD\n 2 - EUR\n 3 - PLN", 1, 3);
            double amount = Converter.GetDoubleInput("Input UAH amount:");

            switch (currency)
            {
                case 1:
                    Console.WriteLine($"UAH to USD: {converter.ToUSD(amount)}");
                    break;
                case 2:
                    Console.WriteLine($"UAH to EUR: {converter.ToEUR(amount)}");
                    break;
                case 3:
                    Console.WriteLine($"UAH to PLN: {converter.ToPLN(amount)}");
                    break;
            }            
        }

        private static void ConvertToUAH(Converter converter)
        {
            
            int currency = Converter.GetIntInput("Select currency:\n 1 - USD\n 2 - EUR\n 3 - PLN", 1, 3);
            double amount = Converter.GetDoubleInput("Input UAH amount:");

            switch (currency)
            {
                case 1:
                    Console.WriteLine($"USD to UAH: {converter.FromUSD(amount)}");
                    break;
                case 2:
                    Console.WriteLine($"EUR to UAH: {converter.FromEUR(amount)}");
                    break;
                case 3:
                    Console.WriteLine($"PLN to UAH: {converter.FromPLN(amount)}");
                    break;
            }   
        }
    }
}