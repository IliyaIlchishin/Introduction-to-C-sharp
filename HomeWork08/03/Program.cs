
int[,,] RandomArray(int a, int b, int c)
{
    int[,,] array = new int[a, b, c];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)

            {
                array[i, j, k] = new Random().Next(10, 99);
            }
        }
    }
    return array;
}

void Print(int[,,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                System.Console.WriteLine($"{array[i, j, k]} ({i},{j},{k}), ");
            }

        }
        System.Console.WriteLine();
    }

}

int [,,] array = RandomArray (2,2,2);
Print (array);
