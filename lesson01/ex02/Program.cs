
System.Console.WriteLine("Please enter number #1");
int number1 = Convert.ToInt32 (Console.ReadLine());

System.Console.WriteLine("Please enter number #2");
int number2 = Convert.ToInt32 (Console.ReadLine());

int value = number1 / number2; 

if (value==number2)
{
    Console.WriteLine ($"Number {number1} is square of Number {number2}");
}

else {
    Console.WriteLine ($"Number {number1} is NOT square of Number {number2}");
}

