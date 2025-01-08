using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        var exchangeRates = new Dictionary<string, double>
        {
            { "USD", 1.0 }, { "EUR", 0.97 }, { "TRY", 36.0 }, { "GBP", 0.56 }
            ,{"KM",1.93}
        };
        while (true)
        {

            Console.WriteLine("Welcome to the Currency Converter Application ");
            Console.WriteLine("Available Currencies: KM , TRY , USD , EUR, GBP");

            Console.Write("Enter the source currency (e.g., KM): ");
            string sourceCurrency = Console.ReadLine()?.ToUpper();
            Console.Write("Enter the target currency (e.g., TRY): ");
            string targetCurrency = Console.ReadLine()?.ToUpper();
            Console.Write("Amount: ");

            if (double.TryParse(Console.ReadLine(), out double amount) &&
              exchangeRates.TryGetValue(sourceCurrency, out double sourceRate) &&
                exchangeRates.TryGetValue(targetCurrency, out double targetRate))
            {
                double result = amount * (targetRate / sourceRate);
                Console.WriteLine($"{amount} {sourceCurrency} = {result} {targetCurrency}");
                Console.WriteLine("Logged Out...\"Press Enter to proceed to the next operation.\"");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid Values. Please check currency codes and amount.");
                Console.ReadLine();
            }
          



        }
        

    }
}



