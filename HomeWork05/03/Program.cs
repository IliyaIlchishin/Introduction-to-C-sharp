void RandomArray(int[] array)
{
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-100, 101);
        System.Console.Write($"{array[i]},  ");
    }
    System.Console.WriteLine();
}

double DiffNums(int[] array)
{
    int length = array.Length;
    double min = 0;
    double max = 0;
    double Diff = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
        
    }
    Diff = max - min;
    System.Console.WriteLine($"The minimal value is : {min}");
    System.Console.WriteLine($"The maximal value is : {max}");
    System.Console.WriteLine($"The diffrence between minimal and maximal values is {Diff}");

    return Diff;

}

int [] a = new int [4];
RandomArray (a);
double result = DiffNums (a); 

/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/