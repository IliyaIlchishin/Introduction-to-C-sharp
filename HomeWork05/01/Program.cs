void RandomArray (int [] array)  
{
    int length = array.Length;
    
    for (int i = 0; i<length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        System.Console.Write($" {array[i]} ");
    }
    System.Console.WriteLine();
}


int EvenNumsArray (int []array)
{
    int length = array.Length;
    int EvenNums = 0; 
    
    for (int i = 0; i<length; i++)
    {
            if ( array[i] % 2 == 0 )
            {
                EvenNums++; 
            }
    }

    return EvenNums; 

}

int [] a = new int [5];
RandomArray (a);
int reslt = EvenNumsArray (a); 
System.Console.WriteLine($"Array consists of {reslt} even number/s");

/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/