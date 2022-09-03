
int SumNumbers(int m, int n)
{
    int sum = 0;
    if (m > n) return sum; 
    else sum += m + SumNumbers(m + 1, n);
    return sum;
}

int sum = SumNumbers(1, 7);
System.Console.WriteLine(sum);

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
