
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write ($" {col[position]}, ");
        position++;
    }
}

int SumArray (int [] array1, int [] array2)
{
int AL = array1.Length;
int sum =0;
int a = 0;

while (a<AL)
{
    sum =sum + (array1 [a] + array2 [a]);
    a++;
}

return sum;
}

int[] Array = new int [3];
int[] Array2 = new int [3];
FillArray (Array);
FillArray (Array2);
System.Console.Write("Array #1:" );
PrintArray (Array);
System.Console.Write("Array #2:" );
PrintArray (Array2);

int sum = SumArray (Array, Array2);
System.Console.WriteLine ($"The sum of 2 arrays : {sum}");
