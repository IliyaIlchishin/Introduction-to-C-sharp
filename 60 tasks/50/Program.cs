
void DBR(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 5);
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

void EvenToOpposite(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); i++)
        {
           // if (array[i,j] > 0 && array[i,j] % 2 = 0) array[i,j] = array[i,j] - (array[i,j] * array[i,j]);
            if (array[i] < 0 && array[i] % 2 = 0) array[i] = array[i] + (array[i] * array[i]);
            
        }
    }

}


int[,] array = new int[3, 3];
DBR(array);
PrintArray(array);


/*
int a = -2;
int opposite = a - (a * a);
System.Console.WriteLine(opposite);

*/
//В двумерном массиве n×k заменить четные элементы на противоположные