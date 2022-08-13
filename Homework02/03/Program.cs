
string Weekday (int day)
{
    string result; 
    if (day <= 5) 
    {
        result = "No, it is working day";
    }
    else result = "Yes, it is weekend";

    return result;
  
}

int GetData() 
{
    Console.WriteLine("Пожалуйста введите день недели: ");
    return Convert.ToInt32(Console.ReadLine());
}


string weekday = Weekday (GetData()); 
System.Console.WriteLine(weekday);


