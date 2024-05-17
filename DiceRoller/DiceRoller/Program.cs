bool goAgain = true;
while (goAgain == true)
{
    Console.WriteLine("How many sides to a dice?");
    string userInput = Console.ReadLine();
    int n = int.Parse(userInput);
    // declaring variables
    int num1;
    int num2;
    int sum;
    if (n == 6)
    {
        num1 = RandNumGen(1, 7);
        num2 = RandNumGen(1, 7);
        sum = num1 + num2;
        Console.WriteLine($"You rolled {num1} and {num2} which is {sum}.");
        Console.WriteLine(Combo(num1, num2));
        Console.WriteLine(Total(num1, num2));
        Console.WriteLine("Go again? y/n");
        userInput = Console.ReadLine();
        if (userInput == "y")
        {
            goAgain = true;
        }
        else
        {
            Console.WriteLine("Bye");
            goAgain = false;
        }
    }
    else
    {
        num1 = RandNumGen(1, n + 1);
        num2 = RandNumGen(1, n + 1);
        sum = num1 + num2;
        Console.WriteLine($"You rolled {num1} and {num2} which is {sum}.");
        Console.WriteLine("Go again? y/n");
        userInput = Console.ReadLine();
        if (userInput == "y")
        {
            goAgain = true;
        }
        else
        {
            Console.WriteLine("Bye Bye");
            goAgain = false;
        }
    }
}
Console.WriteLine(RandNumGen(1, 7));
static int RandNumGen(int a, int b)  // Random Number Generator method.
{
    Random rand = new Random();
    return rand.Next(a, b);
}
static string Combo(int num1, int num2) // Method that returns a string for valid combos
{
    if (num1 == 1 && num2 == 1)
    {
        return "Snake Eyes";
    }
    else if (num1 == 1 && num2 == 2)
    {
        return "Ace Deuce";
    }
    else if (num1 == 6 && num2 == 6)
    {
        return "Box Cars";
    }
    else
    {
        return "hehe";
    }
}
static string Total(int num1, int num2) // Method that returns a string for valid totals
{
    if (num1 + num2 == 7 || num1 + num2 == 11)
    {
        return "Win";
    }
    else if (num1 + num2 == 2 || num1 + num2 == 3 || num1 + num2 == 12)
    {
        return "Craps";
    }
    else
    {
        return "haha";
    }
}
