void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,15);
        index++;
    }
}

int [] BigArray = {};
System.Console.WriteLine(BigArray[3]);