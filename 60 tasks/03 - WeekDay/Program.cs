string Weekday (int day)

{
    string weekday;
    string mistake = "Error!!! Please try again!";
    
    if (day == 1) {
        weekday = "Monday";
        return weekday; };
    if (day == 2) {
        weekday = "Tuesday";
        return weekday;}
    if (day == 3){
        weekday = "Wednesday";
        return weekday; }
    if (day == 4){
        weekday = "Thursday";
        return weekday;}
    if (day == 5){
        weekday = "Friday";
        return weekday;}
    if (day == 6){
        weekday = "Saturday";
        return weekday;}
    if (day == 7){
        weekday = "Sunday";
        return weekday;}
    else return mistake;
   
}

int GetData() 
{
    Console.WriteLine("Please enter the weekday from 1 to 7 ");
    return Convert.ToInt32(Console.ReadLine());
}

string week = Weekday (GetData());
System.Console.WriteLine(week);