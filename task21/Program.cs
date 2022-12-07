/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2 */

Console.WriteLine("Введите координату X точки А: ");
double X = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y точки А: ");
double Y = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z точки А: ");
double Z = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату X точки B: ");
double X1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y точки B: ");
double Y1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z точки B: ");
double Z1 = double.Parse(Console.ReadLine()!);

double subX = X - X1;
double sqX = Math.Pow(subX,2);
double subY = Y- Y1;
double sqY = Math.Pow(subY,2);
double subZ = Z - Z1;
double sqZ = Math.Pow(subZ,2);
double sum = sqX+sqY+sqZ;
Console.WriteLine("Расстояние между точек составляет: " +Math.Round(Math.Sqrt(sum),2));
