int SquareNumber (int number)
{
    int result = number * number;
    return result;
}

int GetData ()
{
    System.Console.WriteLine("Please enter number: ");
    return Convert.ToInt32 (Console.ReadLine());
}

int square = SquareNumber(GetData());
System.Console.WriteLine(square);