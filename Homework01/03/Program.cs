
System.Console.WriteLine("Please enter any number");
int number = Convert.ToInt32 (Console.ReadLine());
int value = number %2 ; 

if (value == 1)
{
System.Console.WriteLine($"The number {number} is odd"); 
}
else
{
    System.Console.WriteLine($"The number {number} is even"); 
}

/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/