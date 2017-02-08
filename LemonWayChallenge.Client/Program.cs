using LemonWayChallenge.Client.LemonWayChallengeServiceReference;
using System;
using System.ServiceModel;

namespace LemonWayChallenge.Client
{
    static class Program
    {
        private const int DEFAULT_NUMBER = 10;

        static void Main(string[] args)
        {
            int number;

            if (!((args.Length == 1) && int.TryParse(args[0], out number)))
            {
                number = DEFAULT_NUMBER;
            }

            ServiceSoapClient service = new ServiceSoapClient();

            try
            {
                Console.WriteLine($"Calculating {number.Ordinal()} Fibonacci sequence number: {service.Fibonacci(number)}");
            }
            catch (EndpointNotFoundException exception)
            {
                Console.WriteLine(exception.InnerException == null ? exception.Message : exception.InnerException.Message);
                Exit(true);
            }
            catch (FaultException exception)
            {
                Console.WriteLine(exception.InnerException == null ? exception.Message : exception.InnerException.Message);
                Exit(true);
            }

            Exit();
        }

        private static void Exit(bool exitWithError = false)
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            if (exitWithError)
            {
                Environment.Exit(1);
            }

            Environment.Exit(0);
        }

        public static string Ordinal(this int number)
        {
            var work = number.ToString();
            if ((number % 100) == 11 || (number % 100) == 12 || (number % 100) == 13)
            {
                return work + "th";
            }

            switch (number % 10)
            {
                case 1: work += "st"; break;
                case 2: work += "nd"; break;
                case 3: work += "rd"; break;
                default: work += "th"; break;
            }

            return work;
        }
    }
}
