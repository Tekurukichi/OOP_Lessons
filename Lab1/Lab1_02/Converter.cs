using System;

namespace Lab1_02
{
    public class Converter
    {
        private double usdRate;
        private double eurRate;
        private double plnRate;
        public Converter(double usd, double eur, double pln)
        {
            this.usdRate = usd;
            this.eurRate = eur;
            this.plnRate = pln;
        }

        public double ConvertToUSD(double amountInUah)
        {
            return amountInUah / usdRate;
        }

        public double ConvertToEUR(double amountInUah)
        {
            return amountInUah / eurRate;
        }

        public double ConvertToPLN(double amountInUah)
        {
            return amountInUah / plnRate;
        }

        public double ConvertFromUSD(double amountInUsd)
        {
            return amountInUsd * usdRate;
        }

        public double ConvertFromEUR(double amountInEur)
        {
            return amountInEur * eurRate;
        }

        public double ConvertFromPLN(double amountInPln)
        {
            return amountInPln * plnRate;
        }
        }
    }
