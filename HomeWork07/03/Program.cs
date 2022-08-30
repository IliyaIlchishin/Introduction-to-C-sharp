
double[,] RandomArray(int m, int n)
{
    double[,] array = new double[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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
        System.Console.WriteLine();
    }
    
}

void СolumnArithmeticMean (double[,] array)
{
    // кол-во строк и столбцов
    int strings = array.GetLength(0);
    int columns = array.GetLength(1);
    double TempAvValue = 0; 

    // массив равен кол-ву столбцов и в каждом среднее арифмет
    double [] ArrayAverageColumnValue = new double [columns];

    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++) 
        {
            TempAvValue = TempAvValue + Convert.ToInt32 (array[j,i]); 
            
        }
        ArrayAverageColumnValue [i] = TempAvValue/strings; 
        TempAvValue = 0; 
    }
        for (int i=0; i<ArrayAverageColumnValue.Length;i++)
        {
            System.Console.WriteLine($"The arythmetic mean of the {i} column is {ArrayAverageColumnValue[i]}");
        }
}

System.Console.WriteLine("Please enter array size");
System.Console.WriteLine("m:");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("n:");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = RandomArray(m, n);
Print(array);
СolumnArithmeticMean (array);



/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/