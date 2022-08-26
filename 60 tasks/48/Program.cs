void DBR(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
    }

}

void PrintArray(int[,] array)
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


int[,] array = new int[2, 2];
DBR(array);
PrintArray(array);


//Показать двумерный массив размером m×n заполненный целыми числами