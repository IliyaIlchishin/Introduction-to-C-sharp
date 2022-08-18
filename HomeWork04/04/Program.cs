void RandomArray (int [] array)  // new int[8]
{
    int length = array.Length;
    
    for (int i = 0; i<length; i++)
    {
        array[i] = new Random().Next(0, 2);
        System.Console.Write($" {array[i]} ");
    }
    System.Console.WriteLine();
}
int [] a = new int [5];
RandomArray (a);