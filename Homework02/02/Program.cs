
int NumberTrasformator(int num)

{
    int result = 0;

    if (num > 99 )
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
    else result = 999;

    return result;
}

int num1 = 933;

int result = NumberTrasformator(num1);
System.Console.WriteLine($"Исходное число {num1}, третья цифра {result}");

//if (result == 0) System.Console.WriteLine("Третьей цифры нет");
//else System.Console.WriteLine($"Исходное число {num1}, третья цифра {result}");




/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/