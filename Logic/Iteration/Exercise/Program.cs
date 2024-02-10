for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}
Console.WriteLine();
for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}
Console.WriteLine();
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}