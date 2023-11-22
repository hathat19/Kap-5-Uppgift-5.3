using System;
namespace Uppgift5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Färger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            //-------------------------------------------

            string[] frågor = { "Vilken färg har bananer?", "Vad heter Ivan i efternamn?", "Vad är meningen med livet?", "I vilken kontinent ligger landet Australien?" };
            string[] svar = { "gul", "ali", "42", "australien" };

            while (true)
            {
                try
                {
                    Console.WriteLine("Vilken fråga vill du svara på? 1-4");
                    int val = int.Parse(Console.ReadLine());

                    //Utskrift
                    Console.WriteLine(frågor[val - 1]);
                    Console.WriteLine("Skriv ditt svar:");

                    //Input
                    if (Console.ReadLine().ToLower() == svar[val - 1])
                    {
                        Console.WriteLine("Du svarade rätt!!");
                    }
                    else
                    {
                        Console.WriteLine("Du svarade fel!");
                    }
                }
                catch
                {
                    Console.WriteLine("Skriv bara ett heltal mellan 1 och 4!");
                }

                //Försök igen?
                Console.WriteLine("Försök igen? j/n");
                if (Console.ReadLine().ToLower() == "n")
                {
                    break;
                }
            }
        }
    }
}

/*Skapa ett program som innehåller två arrayer med 4 element var, den ena arrayen
ska heta frågor och den andra ska heta svar. Programmet ska fungera som ett
frågesportprogram. Spara frågorna och svaren i de arrayer som programmet
innehåller, svaret till frågan som finns på index 0 i frågor-arrayen ska finnas på index
0 i svar-arrayen.
När programmet körs ska användaren få välja en fråga genom att ange ett tal från 1
till 4. Programmet skriver ut en fråga från fråge-arrayen till användaren och använder
svar-arrayen för att se om användaren svarade rätt eller fel.*/