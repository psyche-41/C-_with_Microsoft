using System;
using System.Numerics;

bool continueProgram = true;

while (continueProgram)
{
    try
    {
        Console.Write("Number of the Sequence: ");
        string input = Console.ReadLine().Trim();

        BigInteger num = BigInteger.Parse(input);

        if (num <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
        }
        else
        {
            BigInteger[] list = new BigInteger[(int)num];
            list[0] = 0;
            if (num > 1)
            {
                list[1] = 1;

                for (int i = 2; i < num; i++)
                {
                    list[i] = list[i - 1] + list[i - 2];
                }
            }

            BigInteger sum = 0;
            for (int i = 0; i < num; i++)
            {
                Console.Write(list[i]);
                sum += list[i];
                if (i < (int)num - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("\n\nThe sum of the sequence is " + sum);

            Console.WriteLine("\n\nDo you wish to continue? y|n : ");
            char response = Console.ReadKey().KeyChar;
            if (response == 'y' || response == 'Y')
            {
                // Continue with the program
                Console.WriteLine("\n\nContinuing...");
            }
            else if (response == 'n' || response == 'N')
            {
                // Exit or break from the loop
                Console.WriteLine("\n\nExiting...");
                continueProgram = false;
            }
            else
            {
                Console.WriteLine("\n\nInvalid input. Please enter 'y' for yes or 'n' for no.");
            }
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
    }
    catch (Exception ex)
    {
        Console.WriteLine("An error occurred: " + ex.Message);
    }
}
