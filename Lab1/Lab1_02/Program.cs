using System;

namespace Lab1_02
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("Введіть курси валют (USD, EUR, PLN) по відношенню до гривні:");

                Console.Write("USD: ");
                double usdRate = double.Parse(Console.ReadLine());

                Console.Write("EUR: ");
                double eurRate = double.Parse(Console.ReadLine());

                Console.Write("PLN: ");
                double plnRate = double.Parse(Console.ReadLine());

                Converter converter = new Converter(usdRate, eurRate, plnRate);

                Console.WriteLine("Оберіть тип операції:");
                Console.WriteLine("1. Конвертація з гривні в іноземну валюту");
                Console.WriteLine("2. Конвертація з іноземної валюти в гривню");


                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                    {
                        Console.Write("Введіть суму в гривнях: ");
                        double amountInUah = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Оберіть валюту (USD, EUR, PLN) для конвертації:");
                        string currencyChoice = Console.ReadLine();

                        double convertedAmount = 0;

                        if (currencyChoice == "USD")
                            convertedAmount = converter.ConvertToUSD(amountInUah);
                        else if (currencyChoice == "EUR")
                            convertedAmount = converter.ConvertToEUR(amountInUah);
                        else if (currencyChoice == "PLN")
                            convertedAmount = converter.ConvertToPLN(amountInUah);

                        Console.WriteLine($"Результат конвертації: {convertedAmount} {currencyChoice}");
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Оберіть валюту (USD, EUR, PLN) для конвертації в гривню:");
                        string currencyChoice = Console.ReadLine();

                        Console.Write($"Введіть суму в {currencyChoice}: ");
                        double amountInCurrency = double.Parse(Console.ReadLine());

                        double convertedAmount = 0;

                        if (currencyChoice == "USD")
                            convertedAmount = converter.ConvertFromUSD(amountInCurrency);
                        else if (currencyChoice == "EUR")
                            convertedAmount = converter.ConvertFromEUR(amountInCurrency);
                        else if (currencyChoice == "PLN")
                            convertedAmount = converter.ConvertFromPLN(amountInCurrency);

                        Console.WriteLine($"Результат конвертації: {convertedAmount} UAH");
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Неправильний вибір операції.");
                        break;
                    }
                }

            } catch (Exception e){Console.WriteLine("Неправильна змінна");};
        }
    }
}