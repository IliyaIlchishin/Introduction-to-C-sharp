
int NumberTrasformator(int num)

{
    int result = 0;

    if (num > 99 && num < 999)
    {
        result = num % 10;
    }
    if (num > 999 && num < 9999)
    {
        result = (num % 100) / 10;
    }
    if (num > 9999 && num < 99999)
    {
        result = (num % 1000) / 100;
    }
    if (num > 99999 && num < 999999)
    {
        result = (num % 10000) / 1000;
    }
    if (num > 999999 && num < 9999999)
    {
        result = (num % 100000) / 10000;
    }
    return result;
}

int num1 = 21;

int result = NumberTrasformator(num1);
if (result == 0) System.Console.WriteLine("Третьей цифры нет"); 
else System.Console.WriteLine($"Исходное число {num1}, третья цифра {result}");
