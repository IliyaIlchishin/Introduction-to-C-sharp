void function(int num, int factor)
{
    int result = 0;
    if (num % factor == 0)
    {
        System.Console.WriteLine($" {factor} is the factor of {num}");
    }
    else result = num % factor;
    System.Console.WriteLine($"the excess is {result}");

}

function(44, 7);


//Выяснить, кратно ли число заданному, если нет, вывести остаток.