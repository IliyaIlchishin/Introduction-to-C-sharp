
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
    Console.WriteLine("Please enter any number and we will tell you the 3rd digit: ");
    return Convert.ToInt32(Console.ReadLine());
}

int number = ThirdNum (GetData());
System.Console.WriteLine($"The third digit is {number}");

/*
int num = 975; 
int result = num % 10; 

System.Console.WriteLine(result);*/