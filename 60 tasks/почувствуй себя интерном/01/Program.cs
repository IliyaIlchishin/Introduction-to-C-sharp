void SquareCheck (int num1, int num2)
{
    int square = num1/num2; 
    if (square == num2)
    {
        System.Console.WriteLine($"Number {num1} is the square of number {num2}");
    }
    else System.Console.WriteLine($"Number {num1} is NOT the square of number {num2}");
}



SquareCheck (25,5);
//По двум заданным числам проверять является ли первое квадратом второго