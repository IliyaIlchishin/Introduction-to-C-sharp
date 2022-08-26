
int[] strToInt(string numbers)
{
    numbers = numbers.Replace(" ", " ");

    string[] tempArray = numbers.Split(",");

    int length = tempArray.Length;
    int[] array = new int[length];

    for (int i = 0; i < tempArray.Length; i++)
    {
        array[i] = Convert.ToInt32(tempArray[i]);
    }
    return array;
}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)

        System.Console.Write($"{array[i]}, ");
    System.Console.WriteLine();
}

int Numbers(int[] array)
{
    int positives = 0;

    for (int i = 0; i < array.Length; i ++)
    {
        if (array[i] > 0) positives++;
    }
    return positives;
}


System.Console.WriteLine(" Пожалуйста введите числа через , ");
string numbers = Console.ReadLine();
int[] array = strToInt(numbers);
Print(array);
int QtyofPositives = Numbers (array);
System.Console.WriteLine(QtyofPositives);



/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/