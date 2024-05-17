

static bool IsPassing(double grade)
{
    if (grade > 65)
    {
        return true;
    }else
    {
        return false;
    }
}

Console.WriteLine(IsPassing(65));

static double AverageGrades(double grade1, double grade2, double grade3)
{
    return (grade1 + grade2 + grade3) / 3;
}

Console.WriteLine(AverageGrades(74.3, 78.9, 99.4));

static string OddOrEvenAndPassing(double grade)
{
    int gradeInt = Convert.ToInt32(grade);


    if(IsPassing(gradeInt) == true && gradeInt % 2 == 0)
    {
        return "Passing and even.";
    }
    else if (IsPassing(gradeInt) == false &&  gradeInt % 2 == 0)
    {
        return "Failing and even.";
    }
    else if (IsPassing(gradeInt) == true && gradeInt %2 != 0)
    {
        return "Passing and odd";
    }
    else
    {
        return "failing and odd.";
    }
}

Console.WriteLine(OddOrEvenAndPassing(69.4));
Console.WriteLine(OddOrEvenAndPassing(63.4));
Console.WriteLine(OddOrEvenAndPassing(68.3));
Console.WriteLine(OddOrEvenAndPassing(60.4));