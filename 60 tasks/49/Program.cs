void DBR(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Random.NextDouble(0.5,0.1);
    }

}


void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($" {array[i, j]}, ");
        }
        System.Console.WriteLine();
    }

}


double[,] array = new double [3, 3];
DBR(array);
PrintArray(array);


//Показать двумерный массив размером m×n заполненный вещественными числами