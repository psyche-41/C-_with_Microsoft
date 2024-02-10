// Code Challenge

Console.WriteLine("Toss a coin? y|n");
string x = Console.ReadLine().Trim().ToLower();

if (x == "y")
{
    Random coin = new Random();
    int flip = coin.Next(2);
    Console.WriteLine(flip == 1 ? "head":"tail");
}

/*
// Alternative
string result = "";

if (x == "y")
{
    Random coin = new Random();
    int flip = coin.Next(2);
    
    if (flip == 1)
    {
        result = "head";
    }
    else
    {
        result = "tails";
    }
}
Console.WriteLine(result);
*/

