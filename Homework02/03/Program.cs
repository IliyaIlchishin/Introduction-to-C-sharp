
int Weekday (int day)
{
    int result; 
    if (day <= 5) 
    {
        result = 1;
    }
    else result = 2; 

    return result;
}

int GetData() 
{
    Console.WriteLine("Пожалуйста введите день недели: ");
    return Convert.ToInt32(Console.ReadLine());
}


int weekday = Weekday (GetData()); 
if (weekday == 1) System.Console.WriteLine("Нет, рабочий день");
else System.Console.WriteLine("Да, выходной");


/*  Как внутри функции результату присвоить стринговое значение? Выдает ошибку
string Weekday (int day)
{
    string result; 
    if (day <= 5) 
    {
        result = Convert.ToString (System.Console.WriteLine("Да, выходной"));
    }
    else  result = Convert.ToString (System.Console.WriteLine("Нет, рабочий день"));
    return result;
}

int weekday = Weekday (2); 
System.Console.WriteLine(weekday);
*/
