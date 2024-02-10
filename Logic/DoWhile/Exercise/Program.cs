Random random = new Random();
int current = random.Next(1,11);

/*
//do-while Statement
// Generating random numbers between 1 and 10 until we generate the number 7.
int value = 0;
do
{
    value = random.Next(1,11);
    Console.WriteLine(value);
}
while(value != 7);

// ====

// While Statement
// Iterates only while a random number is greater than some value
while (current > 3)
{
    Console.WriteLine(current);
    current = random.Next(1,11);
}
Console.WriteLine($"Last number: {current}");
*/

// Continue statement
do
{
    current = random.Next(1, 11);

    if (current >= 8) continue; // This will hinder outputing values greater than 7

    Console.WriteLine(current);
} while (current != 7);