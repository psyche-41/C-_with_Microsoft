using System;
using System.Numerics;

Console.Write("Number of the Sequence: ");
string input = Console.ReadLine().Trim();

if (BigInteger.TryParse(input, out BigInteger num))
{
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
        }

        for (int i = 2; i < num; i++)
        {
            list[i] = list[i - 1] + list[i - 2];
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

        Console.WriteLine();
        Console.WriteLine("The sum of the sequence is " + sum);
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid integer.");
}
