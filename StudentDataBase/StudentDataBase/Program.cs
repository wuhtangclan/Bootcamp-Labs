string[] studentNames = new string[6];
studentNames[0] = "Tae Wuh";
studentNames[1] = "Alexandra Lee";
studentNames[2] = "Bruno Koda";
studentNames[3] = "Olive Wuh";
studentNames[4] = "Daisy Lee";
studentNames[5] = "BB Lee";
//string array home town
string[] homeTown = new string[6];
homeTown[0] = "Seoul";
homeTown[1] = "Dearborn";
homeTown[2] = "Pontiac";
homeTown[3] = "Troy";
homeTown[4] = "Flat Rock";
homeTown[5] = "Royal Oak";
// string array favorite food
string[] favoriteFood = new string[6];
favoriteFood[0] = "Korean";
favoriteFood[1] = "Italian";
favoriteFood[2] = "Salmon";
favoriteFood[3] = "Chicken";
favoriteFood[4] = "Eggs";
favoriteFood[5] = "sausage";
bool again = true;
do
{
    Console.WriteLine("Which student would you like to know about? Enter 1-5.");
    int userInput = int.Parse(Console.ReadLine());
    bool valid = true;
    while (valid)
    {
        Console.WriteLine($"That is {studentNames[userInput - 1]}. What do you want to know? Enter 'hometown' or 'favorite food':  ");
        string userInputOne = Console.ReadLine();
        if (userInputOne == "hometown")
        {
            Console.WriteLine($"{studentNames[userInput - 1]} is from {homeTown[userInput - 1]}.");
            valid = false;
        }
        else if (userInputOne == "favorite food")
        {
            Console.WriteLine($"{studentNames[userInput - 1]}'s favorite food is {favoriteFood[userInput - 1]}");
            valid = false;
        }
        else
        {
            Console.WriteLine("That does not exist. Try again.");
            valid = true;
        }
    }
    Console.WriteLine("Would you like to know about another student? y/n");
    string userInputTwo = Console.ReadLine();
    if (userInputTwo == "y")
    {
        again = true;
    }
    else
    {
        Console.WriteLine("bye");
        again = false;
    }
} while (again);

