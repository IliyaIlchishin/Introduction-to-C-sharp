
int[] StringToInteger (string InputNumbers)
{
    InputNumbers= InputNumbers.Replace(" ", " ");

    string[] TemporaryArray = InputNumbers.Split(",");

    int[] array = new int[TemporaryArray.Length];

    for (int i = 0; i < TemporaryArray.Length; i++)
    {
        array[i] = Convert.ToInt32(TemporaryArray[i]);
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
string InputNumbers= Console.ReadLine();
int[] array = StringToInteger (InputNumbers);
Print(array);
int QuantityOfPositives = Numbers (array);
System.Console.WriteLine(QuantityOfPositives);



/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/