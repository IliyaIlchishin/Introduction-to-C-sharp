void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10);
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($" {array[i, j]},  ");
        }
        System.Console.WriteLine();
    }
}

int Av(int[,] array)
{
    int AverageColumn = 0;
    int SumColumn = 0;
    int i = 0; 
    int j = 0; 

    while (i < array.GetLength(0)) 
    {
        SumColumn = SumColumn + array[i,j];

        while (j < array.GetLength(0))
        {
        SumColumn = SumColumn + array[i,j];
        j++;
        }
        
        i++;

    }

    return SumColumn;
}

int[,] array = new int[3, 3];
FillArray(array);
PrintArray(array);
int ColumnAverage = Av (array); 
System.Console.WriteLine(ColumnAverage);





//55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.