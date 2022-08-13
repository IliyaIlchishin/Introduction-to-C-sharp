
int ThirdNum (int number)
{
    while (number > 999) 
    {
            number = number / 10; 
    }
    if (number < 100) System.Console.WriteLine("В числе меньше трех цирф");
    else number = number % 10; 
    return number; 
}

int GetData()
{
    Console.WriteLine("Пожалуйста введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int number = ThirdNum (356572);
System.Console.WriteLine($"The third digit is {number}");

/*
int num = 975; 
int result = num % 10; 

System.Console.WriteLine(result);*/