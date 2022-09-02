int[,] RandomArray(int m, int n)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 5);
        }
    }
    return array;
}

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}, ");  
        }
    }
    System.Console.WriteLine();
    System.Console.WriteLine("_____");
}

void ProductOfMatrix (int[,] matrix1, int[,] matrix2)
{

int[,]ProductOfMatrix = new int [2,2]; 
int ArraySize = 2;

 for (int i = 0; i < ArraySize; i++)
    {
        for (int j = 0; j < ArraySize; j++)
        {
            for (int k = 0; k < ArraySize; k++)
            {
                ProductOfMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
Print(ProductOfMatrix);

}

int[,] matxrix = new int [2,2];
matxrix [0,0] = (2);
matxrix [0,1] = (4);  
matxrix [1,0] = (3);  
matxrix [1,1] = (2);  
int[,] matxrix2 = new int [2,2];
matxrix2 [0,0] = (3);
matxrix2 [0,1] = (4);  
matxrix2 [1,0] = (3);  
matxrix2 [1,1] = (3);  
Print(matxrix);
Print(matxrix2);

ProductOfMatrix(matxrix, matxrix2);




/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

*/