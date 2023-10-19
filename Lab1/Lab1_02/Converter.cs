using System;

namespace Lab1_02
{
    public class Converter
    {

        private double _usd;
        private double _eur;
        private double _pln;

        public Converter(double usd, double eur, double pln)
        {
            _usd = usd;
            _eur = eur;
            _pln = pln;
        }

        public double ToUSD(double uah) => uah / _usd;
        public double FromUSD(double usd) => usd * _usd;

        public double ToEUR(double uah) => uah / _eur;
        public double FromEUR(double eur) => eur * _eur;

        public double ToPLN(double uah) => uah / _pln;
        public double FromPLN(double pln) => pln * _pln;

        public static double GetDoubleInput(string prompt)
        {

            Console.WriteLine(prompt);

            if (!double.TryParse(Console.ReadLine(), out double result))
            {

                Console.WriteLine("Please, input correct value in double/float format");
                return GetDoubleInput(prompt);
            }

            return result;
        }

        public static int GetIntInput(string prompt, int min, int max)
        {

            Console.WriteLine(prompt);

            if (!int.TryParse(Console.ReadLine(), out int result) || result < min || result > max)
            {

                Console.WriteLine($"Please, input correct value in range from {min} to {max} .");
                return GetIntInput(prompt, min, max);
            }

            return result;
        }
    }
}