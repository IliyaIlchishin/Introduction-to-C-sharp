
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
    int Sum = 0 ;
    int[] numsrange = new int[count]; // Array that will collect nums from 10 to 99

    for (int i = 0; i < length; i++)
    {
            if (collection[i] > 10 && collection[i] < 99)
            {
                
                Sum = Sum + collection [i];
                count ++;
                System.Console.WriteLine($"The sum {Sum} in the count {count}");
                System.Console.WriteLine($"Count #{count}");
                // numsrange[count] = collection[i];
                //System.Console.WriteLine($" {numsrange[count]} ");
            
                
        
            }
 
    }
     System.Console.WriteLine($"The total sum of all numbers from 10 to 99 is {Sum}");
    System.Console.WriteLine($" {count} numbers in the range 10 to 99");
}



int[] array = new int [123];

FillArray(array);
NumsINArray(array);
/*
адача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2]-> 0
[10, 11, 12, 13, 14]-> 5
*/
