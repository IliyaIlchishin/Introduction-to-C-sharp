
System.Console.WriteLine("Please enter number from 1 to 7");
int DayNumber = Convert.ToInt32(Console.ReadLine());

if (DayNumber > 7)
{
    System.Console.WriteLine("Error! Please enter the number from 1 to 7");
    DayNumber = Convert.ToInt32(Console.ReadLine());
}

else if (DayNumber == 1)
{
    System.Console.WriteLine("Monday");
}
else if (DayNumber == 2)
{
    System.Console.WriteLine("Tuesday");
}
else if (DayNumber == 3)
{
    System.Console.WriteLine("Wednesday");
}
else if (DayNumber == 4)
{
    System.Console.WriteLine("Thursday");
}
else if (DayNumber == 5)
{
    System.Console.WriteLine("Friday");
}
else if (DayNumber == 6)
{
    System.Console.WriteLine("Saturday");
}
else if (DayNumber == 7)
{
    System.Console.WriteLine("Sunday");
}