string userInput;
string userName;
int num;
bool goAgain = true;

Console.WriteLine("What is your name?");
userName = Console.ReadLine();

while (goAgain)
{
  
    Console.WriteLine($"{userName}, please enter an interger between 1 and 100 inclusive.");
    userInput = Console.ReadLine();
    num = int.Parse(userInput);

    if (num % 2 != 0 && num < 60)
    {
        Console.WriteLine($"{userName}, you have entered {num}, odd and less than 60.");
    }
    else if (num % 2 == 0 && num >= 2 && num <= 24)
    {
        Console.WriteLine($"{userName}, you have entered {num}, even and less than 25.");
    }
    else if (num % 2 == 0 && num >= 26 && num <= 60)
    {
        Console.WriteLine($"{userName}, you have entered {num}, even and between 26 and 60 inclusive.");
    }
    else if (num % 2 == 0 && num > 60 && num <= 100)
    {
        Console.WriteLine($"{userName}, you have entered {num}, even and greater than 60.");
    }
    else if (num % 2 != 0 && num < 60 && num <= 100)
    {
        Console.WriteLine($"{userName}, you have entered {num}, odd and greater than 60.");
    }
    else
    {
        Console.WriteLine($"{userName}, you need to enter an integer between 1 and 100 inclusive.");
    }

    Console.WriteLine("Would you like to go again?");
    userInput = Console.ReadLine();
    if (userInput == "y")
    {
        goAgain = true;
    }
    else
    {
        goAgain= false;
    }
}