int NumSum(int num)
{

    int sum = 0;
    for (int i = num; i > 0; i = i / 10)
    {
        sum = sum + i % 10;
    }
    return sum;

}
int sum = NumSum (411);
System.Console.WriteLine(sum);