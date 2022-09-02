

void ArrayRearrangeMethod(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int c = array.GetLength(1) - 1; c > 0; c--)
            {
                //1             2
                if (array[i, j] < array[i, c])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, c];
                    array[i, c] = temp;
                }
            }
        }
    }
}

void Print(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}, ");

        }
        System.Console.WriteLine();
    }

}

int[,] array = new int[3, 4];
array[0, 0] = 1;
array[0, 1] = 4;
array[0, 2] = 7;
array[0, 3] = 2;
array[1, 0] = 5;
array[1, 1] = 9;
array[1, 2] = 2;
array[1, 3] = 3;
array[2, 0] = 8;
array[2, 1] = 4;
array[2, 2] = 4;
array[2, 3] = 2;


Print(array);
ArrayRearrangeMethod(array);
System.Console.WriteLine();
Print(array);

/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
