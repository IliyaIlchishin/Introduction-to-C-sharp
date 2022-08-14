
bool Palindrom(int[] array)

{
    int index1 = 0;
    int index2 = 5;
    bool result = false;
   
    if (array[index1] == array[index2])
    {
        System.Console.WriteLine($"{array [index1]}, {array [index2]}");
        index1++; index2--;

        System.Console.WriteLine($"{array [index1]}, {array [index2]}");
        if (array[index1] == array[index2])
        {
            index1++; index2--;
            System.Console.WriteLine($"{array [index1]}, {array [index2]}");

            if (array[index1] == array[index2])
            {
                index1++; index2--;
                System.Console.WriteLine($"{array [index1]}, {array [index2]}");
                result = true;
            } else result = false;

        } else result = false;

    } else result = false;

    return result;

};
         
int[] array = { 1, 3, 3, 3, 3, 1 };
bool NumCheck = Palindrom(array);
if (NumCheck == true) System.Console.WriteLine("The number is a Palindrom");
else System.Console.WriteLine("The number is NOT a Palindrom");

/*
Задача 19
Напишите метод, который принимает на вход шестизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
строки использовать нельзя
*/
