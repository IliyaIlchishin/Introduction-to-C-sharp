
double Coordinates (double[] a, double[] b)
{

double distance = Math.Pow (Math.Pow(a[0] - b[0], 2) +  Math.Pow(a[1]- b[1], 2) + Math.Pow(a[2] - b[2], 2), 0.5);

return distance; 

}

double [] a = {3,6,8};
double [] b = {2,1,-7};

double [] c = {7,-5,0};
double [] d = {1,-1,9};

double distance = Coordinates (c, d );
System.Console.WriteLine(distance);



