int heroHP = 10;
int monsterHP = 10;

Random random = new Random();
int attackDamage = 0;

Console.WriteLine("Hero will attack first!");

while(true)
{
    int health = 0;

    attackDamage = random.Next(1,11);
    monsterHP -= attackDamage;
    Console.WriteLine($"Hero's Damage: {attackDamage}");

    if (monsterHP <= 0) 
    {
        health = monsterHP - monsterHP;
        monsterHP += monsterHP;
        Console.WriteLine($"Monster's HP: {health}\n");
        Console.WriteLine("Hero Wins!");
        break;
    }
    else
    {
        Console.WriteLine($"Monster's HP: {monsterHP}\n");
    }

    attackDamage = random.Next(1,11);
    heroHP -= attackDamage;
    Console.WriteLine($"Monster's Damage: {attackDamage}");

    if (heroHP <= 0) 
    {
        health = heroHP - heroHP;
        Console.WriteLine($"Hero's HP: {health}\n");
        Console.WriteLine("Monster Wins!");
        break;
    }
    else
    {
        Console.WriteLine($"Hero's HP: {heroHP}\n");
    }
}