void WeekDay(int day)
{
    if (day <= 5) System.Console.WriteLine("working day");
    if (day == 6 || day == 7) System.Console.WriteLine("Weekend");
    if (day > 7) System.Console.WriteLine("The number is not correct. Please enter number from 1-7");
}

WeekDay(6);

// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 