//пока в процессе выполнения


double Root (int num)
{   double root = 0; 
     if (num > 0)
            {
                double r = num / 3;
                int i;
                for (i = 0; i < 32; i++)
                r = (r + num / r) / 2;
                root = r; 
            }
        return root;
}


void NumTransition (int num, int numeralSys)
{   
    //округлить корень числа в большую сторону, чтобы понять кол-во символов
    int arraySize =Convert.ToInt32 (Math.Ceiling(Root(num)));

    int [] array = new int [arraySize];

    int i = arraySize-1; 

            //10
    while (num > 0)
    {
        array[i] = num  % numeralSys;
        num = num / 2; 
        i--;
    }

    for (int a = 0; a <array.Length; a++) System.Console.Write($"{array[a]}");

}
int num =10;
int system = 2; 

System.Console.Write ($"Number {num} in numeral system {system} will be :");
NumTransition (num,system);
System.Console.WriteLine();


/*
Написать метод, принимающий десятиченое представление и основание СС в которую нужно это число перевести, 2<= основание СС<= 9
10,2 -> 1010
10,8 -> 12
6,6 -> 10


Binary Number : 10101
Decimal Calculation:
Step1: 1 * 2^0=1
Step2: 0 * 2^1=0
Step3: 1 * 2^2=4
Step4: 0 * 2^3=0
Step5: 1 * 2^4 =16
So, the Decimal Number = 1 + 0 + 4 + 0 + 16 = 21

*/