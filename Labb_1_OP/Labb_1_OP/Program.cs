using System;

namespace Laboration1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tiden det tar att åka mellan städerna i timmar och minuter
            int flightDurationHours = 7;
            int flightDurationMinutes = 25;

            // Tidsskillnaden mellan New York och Stockholm
            int timeDifference = 6;

            // Variabler för avgångstid
            int departureHour;
            int departureMinute;

            // Variabel för att hålla reda på om programmet ska fortsätta köras
            bool running = true;

            // Loopar tills användaren väljer att avsluta
            while (running)
            {
                // Välkomstmeddelande
                Console.WriteLine("****************************************************************************");
                Console.WriteLine("Välkommen till flytidsberäknaren\n");
                Console.WriteLine("Vilket flyg vill du se detaljerad information om? (svara med siffra)");
                Console.WriteLine("1. Stockholm - New York");
                Console.WriteLine("2. New York - Stockholm");
                Console.WriteLine("3. Avsluta programmet");
                Console.Write("Skriv ditt val här: ");
                string choice = Console.ReadLine();

                Console.Clear();

                // Hantering av val
                if (choice == "1")
                {
                    departureHour = 14;
                    departureMinute = 3;

                    int LandingHours = departureHour + flightDurationHours - timeDifference;
                    int LandingMinutes = departureMinute + flightDurationMinutes;

                    Console.WriteLine("****************************************************************************");
                    Console.WriteLine("");
                    Console.WriteLine($"Avgångstid från Stockholm: {departureHour:D2}:{departureMinute:D2}\n" +
                                      $"Ankomsttid till New York: {LandingHours:D2}:{LandingMinutes:D2}\n");
                    Console.WriteLine("****************************************************************************");
                    running = false;
                }
                else if (choice == "2")
                {
                    departureHour = 10;
                    departureMinute = 10;

                    int LandingHours = departureHour + flightDurationHours + timeDifference;
                    int LandingMinutes = departureMinute + flightDurationMinutes;

                    if (LandingMinutes >= 60)
                    {
                        LandingHours += LandingMinutes / 60;
                        LandingMinutes %= 60;
                    }

                    LandingHours %= 24;

                    Console.WriteLine("****************************************************************************");
                    Console.WriteLine("");
                    Console.WriteLine($"Avgångstid från New York: {departureHour:D2}:{departureMinute:D2}\n" +
                                      $"Ankomsttid till Stockholm: {LandingHours:D2}:{LandingMinutes:D2}\n");
                    Console.WriteLine("****************************************************************************");
                    break;
                }
                else if (choice == "3")
                {
                    Console.WriteLine("****************************************************************************");
                    Console.WriteLine("Programmet avslutas. Tack för att du använde flygtidsberäknaren!");
                    Console.WriteLine("****************************************************************************");
                    running = false; // Avslutar loopen
                }
                else
                {
                    Console.WriteLine("****************************************************************************");
                    Console.WriteLine("Ogiltigt val, försök igen.");
                    Console.WriteLine("****************************************************************************");
                }

                // Om loopen fortfarande körs, vänta på ett tangenttryck innan menyn visas igen
                if (running)
                {
                    Console.WriteLine("\nTryck på valfri tangent för att fortsätta...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}