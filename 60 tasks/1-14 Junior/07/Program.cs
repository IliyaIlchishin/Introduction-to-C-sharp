void NumRange (int num) 
{
    int start = num - (num*2); 

    for (int i = start; i <= num; i++)
    {
        System.Console.WriteLine(i);
    }

}

NumRange (5);

//Показать числа от -N до N