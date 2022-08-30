double [,] RandomArray(int m, int n)
{
    double [,] array = new double[m, n];

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

System.Console.WriteLine("Please enter array size");
System.Console.WriteLine("m:");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("n:");
int n = Convert.ToInt32(Console.ReadLine());

double [,]array = RandomArray(n,m);
Print(array);

/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/