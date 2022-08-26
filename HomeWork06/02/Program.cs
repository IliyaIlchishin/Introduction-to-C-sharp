
System.Console.WriteLine("Please enter k1");
double k1 = Convert.ToDouble (Console.ReadLine());

System.Console.WriteLine("Please enter k2");
double k2 = Convert.ToDouble (Console.ReadLine());

System.Console.WriteLine("Please enter b1");
double b1 = Convert.ToDouble (Console.ReadLine());

System.Console.WriteLine("Please enter b2");
double b2 = Convert.ToDouble (Console.ReadLine());

double[,] array = new double[2, 2];
array[0, 0] = (k1);
array[0, 1] = (k2);
array[1, 0] = (b1);
array[1, 1] = (b2);

//          (b1-b2)/(k2-k1)
double x = (array[1, 0] - array[1, 1]) / (array[0, 1] - array[0, 0]);
System.Console.WriteLine($"x: {x}");
// y = (k2 * b1 - k1 * b2) / (k2 - k1);
double y = (array[0, 1] * array[1, 0] - array[0, 0]* array[1, 1]) / (array[0, 1] - array[0, 0]); 
System.Console.WriteLine($"y: {y}");
System.Console.WriteLine($"Точки пересекаются в {x}, {y}");

/*

Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/