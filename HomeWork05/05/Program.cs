
int NumOfDigits (int Binary) 

{
    int digits = 0; 
    if (Binary <10) digits = 1;
    if (Binary >9) digits = 2; 
    if (Binary >99) digits = 3; 
    if (Binary >999) digits = 4; 
    if (Binary >9999) digits = 5; 
    if (Binary >99999) digits = 6; 
    if (Binary >999999) digits = 7; 
    if (Binary >9999999) digits = 8; 
    if (Binary >99999999) digits = 9; 
    if (Binary >999999999) digits = 10; 

    return digits;
}


int digit = NumOfDigits (961367);
int [] array = new int [digit]; 
int num = 961367;

for (int i = 0; i < digit; i++)
{

    array [i] = num % 10; 
    System.Console.WriteLine(num);

}



/*
int value = num % 10; 
System.Console.WriteLine(value);

 int sum = 0;
    for (int i = num; i > 0; i = i / 10)
    {
        sum = sum + i % 10;
    }
    return sum;

/*
int NumConverter (int Binary)
{

} 
*/
/*


int turn = 0; 
for (int i = 0; i > 0; i++ )

int sum= 0;
int array = new int [i]; 

for (int i = 0;i<length; i++)
{
    sum = sum + (num [i]*2) 

}

конвертировать в array
степень через счетчик 

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
So, the Decimal Number = 1 + 0 + 4 + 0 + 16 = 20


*/