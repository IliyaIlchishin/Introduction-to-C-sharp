System.Console.WriteLine("Please enter number 1");
int a = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine("Please enter number 2");
int b = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine("Please enter number 3");
int c = Convert.ToInt32 (Console.ReadLine());

int max; 

if (a>b && a>c)
{
    max = a; 
}

    else if (b > c)
    {
    max = b;
    }

else 
{
 max = c;
}

System.Console.WriteLine($" the maximum number {max} ");

