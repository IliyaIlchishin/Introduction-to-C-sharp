
System.Console.WriteLine("Введите число");

int number = Convert.ToInt32 (Console.ReadLine());
int value = number % 2 ; 

if (value == 1)

{
System.Console.WriteLine($"Число {number} нечетное"); 
}

else
{
    System.Console.WriteLine($"Число {number} четное"); 
}

