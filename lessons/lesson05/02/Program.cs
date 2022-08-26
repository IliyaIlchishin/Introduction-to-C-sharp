/*
int Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
System.Console.WriteLine(Factorial(4));
*/
                //5 
int Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

// (5-1)+(5-2) = 7
// (4-1)+(3-2) = 4
// (3-1)+(1-2) = 2
for (int i = 1; i <25; i++)
{
    Console.WriteLine(Fibonacci(i));
}