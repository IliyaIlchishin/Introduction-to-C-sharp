int Max (int arg1, int arg2, int arg3, int arg4, int arg5)
{
int result = 0;
if (arg1 > result) result=arg1;
if (arg2 > result) result=arg2;
if (arg3 > result) result=arg3;
if (arg4 > result) result=arg4;
if (arg5 > result) result=arg5;

return result;
}

int GetData() 
{
    Console.WriteLine("Please enter the value: ");
    return Convert.ToInt32(Console.ReadLine());
}

int max = Max (GetData (),GetData(),GetData(),GetData(),GetData());
System.Console.WriteLine($"the maximal value: {max} ");