using System;
using System.Text;

void BinaryToDecimal(int[] BinaryArray)
{
    int length = BinaryArray.Length;
    double result = 0;
    int pow = 0;
                        
    for (int i = length -1; i >= 0; i--)
    {
        result = result + Math.Pow(2, pow) * BinaryArray[i];
        System.Console.WriteLine($"Array value [{i}] - {BinaryArray[i]}");
        pow++;
        System.Console.WriteLine($"the result round [{i}] - {result}");
    }
    System.Console.WriteLine($"the FINAL result {result}");
}
int[] binary = { 1, 1, 0, 0};
BinaryToDecimal(binary);

/*
int NumOfDigits(int Binary)

{
    int digits = 0;
    if (Binary < 10) digits = 1;
    if (Binary > 9) digits = 2;
    if (Binary > 99) digits = 3;
    if (Binary > 999) digits = 4;
    if (Binary > 9999) digits = 5;
    if (Binary > 99999) digits = 6;
    if (Binary > 999999) digits = 7;
    if (Binary > 9999999) digits = 8;
    if (Binary > 99999999) digits = 9;
    if (Binary > 999999999) digits = 10;

    return digits;
}

Написать метод, принимающий бинарное представление числа
и возвращающее десятиченое представление числа
1 1 0 0 -> 12
1 1 0 1 -> 13

Binary Number : 10101
Decimal Calculation:
Step1: 1 * 2^0=1
Step2: 0 * 2^1=0
Step3: 1 * 2^2=4
Step4: 0 * 2^3=0
Step5: 1 * 2^4 =16
So, the Decimal Number = 1 + 0 + 4 + 0 + 16 = 21

*/