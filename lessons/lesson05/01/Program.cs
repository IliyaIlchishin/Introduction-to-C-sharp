
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        System.Console.Write ($" {array[i ,j]},  ");
        }
        System.Console.WriteLine();
    }
}


void FillArray(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        array[i,j] = new Random().Next(0, 10);
    }
}

int [,] array = new int [5,5]; 
PrintArray(array);
System.Console.WriteLine("Array is initialized");
FillArray(array);
PrintArray(array);

