
int BiggerNum (int num1,int num2, int num3)
{
    int max = 0;
    if (num1 > max) max = num1;
    if (num2 > max) max = num2;
    if (num3 > max) max = num3;
    
    return max;
}

int max = BiggerNum (-5,56,15);
System.Console.WriteLine(max);


//4. Найти максимальное из трех чисел