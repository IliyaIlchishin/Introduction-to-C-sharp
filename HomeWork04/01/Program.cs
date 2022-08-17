/* Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
нельзя использовать pow
3, 5 -> 243 (3⁵)
2, 4 -> 168
*/       
//                               1   2    3   4
//           2      4    = 16    2   4    8   16 
int Pow (int a, int b)
{
    int result = a;

    for (int i = 1; i < b; i++ )
    {
        result = result * a;
        
    }
    return result;
}

int pow = Pow (2,8);
System.Console.WriteLine(pow);