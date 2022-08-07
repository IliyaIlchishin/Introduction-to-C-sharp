int[] array = { 41, 121, 31, 43, 11, 12, 44, 31, -55 };

int n = array.Length;
int find = 31;
int index = 0;

while (index < n)
{
if (array[index] == find)
{
    System.Console.WriteLine(index);
    break;
}
index++; 

}