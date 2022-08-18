
int BiggerNum (int num1,int num2)
{
    int max = 0;
    if (num1 > num2) max = num1;
    else max = num2;
    return max;
}

int max = BiggerNum (534,65);
System.Console.WriteLine(max);

// 2. Даны два числа. Показать большее и меньшее число