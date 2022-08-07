int Max(int arg1, int arg2, int arg3, int arg4)
{
    int result = 0;
    if (arg1 > result) result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    if (arg4 > result) result = arg4;
    return result;
}


int a = 123;
int b = 223;
int c = 425;
int d = 14;
int a1 = 435;
int b1 = 913;
int c1 = -235;
int d1 = 38;
int a2 = 42;
int b2 = 123;
int c2 = 97;
int d2 = 432;
int a3 = 57;
int b3 = 326;
int c3 = 1305;
int d3 = 848;

/*int max1 = Max(a, b, c, d);
int max2 = Max(a1, b1, c1, d1);
int max3 = Max(a2, b2, c2, d2);
int max4 = Max(a3, b3, c3, d3);
*/
int max = Max (
    Max(a1, b1, c1, d1),
    Max(a, b, c, d),
    Max(a2, b2, c2, d2),
    Max(a3, b3, c3, d3));

System.Console.WriteLine($"Максимальное число {max} ");