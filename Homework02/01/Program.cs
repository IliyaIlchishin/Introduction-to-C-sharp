int NumberTrasformator(int num)

{
    int result = (num % 100) / 10;
    return result;
}

int num1 = 456;
int num2 = 782;
int num3 = 918;

int result = NumberTrasformator (num2);
System.Console.WriteLine(result);

