
void RandomArray (int [] array)  
{
    int length = array.Length;
    
    for (int i = 0; i<length; i++)
    {
        array[i] = new Random().Next(-100, 101);
        System.Console.Write($" Num -{array[i]} ind {i},  ");
    }
    System.Console.WriteLine();
}


int OddNumsArray (int []array)
{
    int length = array.Length;
    int OddNumsSum = 0; 
    
    for (int i = 0; i<length;i++)
    {
            if ( i % 2 == 0 )
            {
                System.Console.WriteLine($"index {i} of the array is not odd");
            }

            else OddNumsSum = OddNumsSum + array [i];
    }

    return OddNumsSum; 

}

int [] a = new int [5];
RandomArray (a);
int reslt = OddNumsArray (a); 
System.Console.WriteLine($"The sum of odd numbers in the array is {reslt}");


/*

Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
