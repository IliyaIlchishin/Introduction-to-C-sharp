void SquareCheck (int num1, int num2)
{
    

    if (num1/num2==num2 ) System.Console.WriteLine($"Number {num1} is the square of number {num2}");
    if (num2/num1==num1 ) System.Console.WriteLine($"Number {num2} is the square of number {num1}");
    else System.Console.WriteLine($"Squares are not detected");
}

SquareCheck (9,9);

//17. По двум заданным числам проверять является ли одно квадратом другого