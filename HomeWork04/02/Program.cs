int NumSun(int num)
{

    int sum = 0;
    for (int i = num; i > 0; i = i / 10)
    {
        sum = sum + i % 10;
    }
    return sum;

}
int sum = NumSun (488);
System.Console.WriteLine(sum);