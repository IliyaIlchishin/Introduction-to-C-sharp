/* Option #1
string cube(int a)

{   //              0  1   2  3    4    5    6     7    8    9

    int[] array = { 1, 8, 27, 64, 125, 216, 343, 512, 729, 1000 };
    int index = 0;
    string value = ($"{array[0]}");

    do
    {
        value = $"{array[index]}";
        System.Console.Write($" {value} ");
        index++;

    }
    while (index < a);
    return value = "";
}

string cubetable = cube(7);
System.Console.WriteLine(cubetable);
*/

int cube(int a)

{   
    int[] array = new int [a];
    int ArLength = array.Length;
    int value = 0;
    int index = 1;

    
    while (index <= a)
    {
        value = index * index * index;
        System.Console.WriteLine(value);
        index++;
    }

    return value;
}

int cubetable = cube(5);
System.Console.WriteLine(cubetable);
