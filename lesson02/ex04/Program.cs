﻿
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 25);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine (col[position]);
        position++;
    }
}

int Index0f(int[]collection,int find)
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


int[] BigArray = new int [10];
FillArray(BigArray);
PrintArray(BigArray);
System.Console.WriteLine();

int pos = Index0f(BigArray,11);
System.Console.WriteLine(pos);

