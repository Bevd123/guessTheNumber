using System;
class Program
{
    static void Main()
    {
        Random random = new Random();
        int[] randomNumber = GenerateRandomNumber();
        int[] userGuess = new int[4];
        int attempts = 0;

        Console.WriteLine("Willkommen zum Zahlerrätselspiel!");
        Console.WriteLine("Ich habe eine vierstellige Zahl generiert. Versuche, sie zu erraten.");

        try
        {
            do
            {
                Console.Write("Gib deine Vermutung ein (vier Zahlen, getrennt durch Leerzeichen): ");
                string input = Console.ReadLine();
                string[] inputArray = input.Split(' ');


                for (int i = 0; i < 4; i++)
                {
                    userGuess[i] = int.Parse(inputArray[i]);

                    if (randomNumber.Contains(userGuess[i]) && !(randomNumber[i] == userGuess[i]))
                    {
                        do
                        {
                            Console.WriteLine($"Die {i + 1}. Zahl ist an der falschen stelle");
                        } while (false);
                    }
                    if (randomNumber[i] == userGuess[i])
                    {
                        Console.WriteLine($"Die {i + 1}. Zahl ist an der richtigen stelle");
                    }
                    if (randomNumber == userGuess)
                    {
                        Console.WriteLine("Du hast die Zahl erraten!");
                        Console.WriteLine($"Du hast {attempts} Versuche gebraucht.");
                        break;
                    }
                    if (!(randomNumber.Contains(userGuess[i])))
                    {
                        Console.WriteLine($"Die {i + 1}. Zahl ist nicht in der Zahl enthalten");
                    }
                    {
                    }
                }

            } while (true);
        }
        catch (System.FormatException ex)
        {
            Console.WriteLine("Du hast eine ungültige Eingabe gemacht. Bitte neu starten!");
            Console.ReadLine();
            System.Environment.Exit(1);
        }
        Console.WriteLine("Du hast gewonnen!");
        Console.ReadLine();
    }

    static int[] GenerateRandomNumber()
    {
        Random random = new Random();
        int[] number = new int[4];
        for (int i = 0; i < 4; i++)
        {
            number[i] = random.Next(10);
        }
        return number;
    }
}