string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}

/*
// My code
string permission = "Admin|Manager";
int level = 55;

bool admin = permission.Contains("Admin");
bool manager = permission.Contains("Manager");

// Business Rules
if (admin && (level > 55))
{
    Console.WriteLine("Welcome, Super Admin user.");
}
else if (admin && (level <= 55))
{
    Console.WriteLine("Welcome, Admin user.");    
}
else if (manager && (level >= 20))
{
    Console.WriteLine("Contact an Admin for access.");
}
else
{
    Console.WriteLine("You do not have sufficient privileges");
}
*/