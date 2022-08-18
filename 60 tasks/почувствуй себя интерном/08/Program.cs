void EvenNums(int num)
{
    int start = num - num;

    while (start <= num) 
    {
        if (start % 2 == 0)
        {
        System.Console.WriteLine(start);
        }
        start++;
    }    
    
}

EvenNums(22);

//8. Показать четные числа от 1 до N