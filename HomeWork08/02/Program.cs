

int[,] RandomArray(int m, int n)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
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

void ColumnArithmeticMean(int[,] array)
{
    //
    int[] ArrayStringSum = new int[array.GetLength(0)];
    int TempStringSum = 0;
   

    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            TempStringSum = TempStringSum + Convert.ToInt32(array[i, j]);
        }
        ArrayStringSum[i] = TempStringSum;
        TempStringSum = 0;
        System.Console.WriteLine($"The sum of elements at string {i} is {ArrayStringSum[i]}");
    }

    int MinSum = ArrayStringSum[0];
    int MinSumIndex = 0;

    for (int i = 0; i < ArrayStringSum.Length; i++)
    {   //
        if (MinSum >= ArrayStringSum[i])
        {
            MinSum = ArrayStringSum[i];
            MinSumIndex = i;
        }
    }

    System.Console.WriteLine($"The string {MinSumIndex} has the minimal sum {MinSum}");
}

System.Console.WriteLine("Please enter array size");
System.Console.WriteLine("m:");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("n:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = RandomArray(m, n);
Print(array);
ColumnArithmeticMean(array);




//Задача 56: 
