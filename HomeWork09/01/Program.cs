
void Numbers(int m, int n)
{
    System.Console.WriteLine(" " + m);

    if (m < n) Numbers(m + 1, n);
}

Numbers(1, 9);


