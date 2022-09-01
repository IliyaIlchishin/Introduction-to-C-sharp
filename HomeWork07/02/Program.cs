
double[,] RandomArray(int m, int n)
{
    double[,] array = new double[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 50);
        }
    }
    return array;
}

void Print(double[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}, ");

        }
    }
    System.Console.WriteLine();
}

double ArrayIndexValue(double[,] array)
{
    System.Console.WriteLine("Please enter array index m:");
    int m = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("n:");
    int n = Convert.ToInt32(Console.ReadLine());

    double IndexValue = 0;
    int i = array.GetLength(0);
    int j = array.GetLength(1);


    if (m < i && n < j) IndexValue = Convert.ToDouble(array[m, n]);
    if (m >= i || n >= j) 
    {
        System.Console.WriteLine("Index is outside the bounds of the array.");
        return 0;
    };

    return IndexValue;
}

System.Console.WriteLine("Please enter array size");
System.Console.WriteLine("m:");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("n:");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = RandomArray(n, m);
Print(array);
double indexValue = ArrayIndexValue(array);
System.Console.WriteLine($"{indexValue}");


/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

*/