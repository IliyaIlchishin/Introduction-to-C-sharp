int MakeNegative(int number)
{
    int value = Convert.ToInt32(Console.ReadLine());
    if (value > 0)
    {
        value = value - (value * 2);
    }
    else value += 0;

    return value;
}


System.Console.WriteLine("Enter any number");

int number = MakeNegative (number = 0);

System.Console.WriteLine(number);