
void FillArray(int[] collection)
{
    int lenghth = collection.Length;
    for (int i = 0; i < lenghth; i++)
    {
        collection[i] = new Random().Next(-100, 100);
        System.Console.WriteLine(collection[i]);
    }

}

void NumsINArray(int[] collection)
{
    int length = collection.Length;
    int count = 0;
    int[] numsrange = new int[count]; // Array that will collect nums from 10 to 99

    //1. we need to go through the whole array
    //2. we need to chcek if the number is from the necessary range of nums
    //3. we need to take this nums and put them into another array

    for (int i = 0; i < length; i++)
    {
        for (count = 0; count < i; count++)
        {
            if (collection[i] > 10 && collection[i] < 99)
            {
                numsrange[count] = collection[i];
                System.Console.WriteLine($" {numsrange[count]} ");
            }
        }
    }
}


//int len = 10;
int[] array = { -24, 23, 88, 153, 85, 90, 45, -44 };

//FillArray(array);
NumsINArray(array);

/*
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int Index0f(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;

        }
        index++;
    }
    return position;
}


int[] BigArray = new int[10];
FillArray(BigArray);
PrintArray(BigArray);
System.Console.WriteLine();

int pos = Index0f(BigArray, 11);
System.Console.WriteLine(pos);


адача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2]-> 0
[10, 11, 12, 13, 14]-> 5
sergei kamianetskii: ===
sergei kamianetskii: Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6]-> 36 21
*/