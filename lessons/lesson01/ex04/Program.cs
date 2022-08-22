
System.Console.WriteLine("Please enter number from 1 to 100");
int Number = Convert.ToInt32(Console.ReadLine());
int NegativeNumber = (Number / Number) - (Number + 2);


while (Number != NegativeNumber)
{
    System.Console.Write($" {Number} ");
    Number--;

}

