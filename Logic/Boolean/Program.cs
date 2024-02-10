/*
int saleAmount = 10;
int discount = saleAmount > 1000 ? 100 : 50; // "?" is a conditional operator

Console.WriteLine($"Discount: {discount}");
*/

/*
int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
*/


// Code Challenge
/*
Console.WriteLine("Toss a coin? y|n");
string x = Console.ReadLine().Trim().ToLower();
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

