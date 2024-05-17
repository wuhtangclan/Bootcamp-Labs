// See https://aka.ms/new-console-template for more information
using System.Net.Security;
string userInput;
bool runProgram = true;

//#1
do
{
    Console.WriteLine("Hello World!");
    Console.WriteLine("Would you like to go again?");
    userInput = Console.ReadLine();
    if(userInput == "y")
    {
        runProgram = true;
       

    }
    else
    {
        Console.WriteLine("Bye");
        runProgram = false;
    }

}
while (runProgram);


//#2
int num;
do
{

    Console.WriteLine("Please enter a number");
    userInput = Console.ReadLine();
    num = int.Parse(userInput);

    for (int i = 0; i <= num; i++)
    {
        Console.WriteLine(i);
    }

    for (int i = num; i >= 0; i--)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Would you like to go again?");
    userInput = Console.ReadLine();

    if (userInput == "y")
    {
        runProgram = true;
    }
    else
    {
        Console.WriteLine("Bye");
        runProgram=false;
    }
} 
while(runProgram);

//#3
bool doorLocked = true;
while (doorLocked == true)
{
    Console.WriteLine("Enter the keycode");
    userInput= Console.ReadLine();  
    if (userInput == "13579") 
    { 
        Console.WriteLine("You may enter!");
        doorLocked = false;
    }
    else
    {
        Console.WriteLine("Try again.");
    }
} 



//#4
doorLocked = true;
int numberOfAttempts =0;
while (doorLocked ==true)
{
    if (numberOfAttempts < 5)
    {
        Console.WriteLine("Enter the passcode");
        userInput = Console.ReadLine();

        if (userInput == "13579")
        {
            Console.WriteLine("You may enter!");
            doorLocked = false;
        }
        else
        {
            numberOfAttempts += 1; ;
            Console.WriteLine("Try again.");
        }
    }
    else
    {
        Console.WriteLine("You exceed max attempts. Bye");
        doorLocked =false;
    }
}


//#5

/* doorLocked = true;

do
{
    Console.WriteLine("Enter the passcode");
    userInput = Console.ReadLine();
} 
while(doorLocked == true);
{
    if (numberOfAttempts < 5)
    {

        if (userInput == "13579")
        {
            Console.WriteLine("You may enter!");
            doorLocked = false;
        }
        else
        {
            numberOfAttempts += 1; ;
            Console.WriteLine("Try again.");
        }
    }
    else
    {
        Console.WriteLine("You exceed max attempts. Bye");
        doorLocked = false;
    }
}
*/






