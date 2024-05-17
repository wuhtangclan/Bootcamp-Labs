bool again = true;
while (again)
{
    Console.WriteLine("Enter a number.");
    int userInput = int.Parse(Console.ReadLine());
    int sum = 0;

    for (int i = 0; i <= userInput; i++)
    {
        sum += i;
    }
    Console.WriteLine($"{sum}");
    Console.WriteLine("Again?");
    string userInputOne = Console.ReadLine();
    if (userInputOne == "y")
    {
        again = true;
    }
    else
    {
        again = false;
    }
}
