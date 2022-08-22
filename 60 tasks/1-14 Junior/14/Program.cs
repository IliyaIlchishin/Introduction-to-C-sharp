void ThirdDigit (int num)
{
    if (num>99)
    {
        while (num>999)
        {
            num= num/10;
        }
        int res = num % 10;
        System.Console.WriteLine(res);
    }
    else System.Console.WriteLine("There is less than 3 digits in the number");

}

ThirdDigit(328451);

//Найти третью цифру числа или сообщить, что её нет