// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату xa:");
double xa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату ya:");
double ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату za:");
double za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату xb:");
double xb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату yb:");
double yb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату zb:");
double zb = Convert.ToInt32(Console.ReadLine());

double AB = Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2) + Math.Pow(zb-za, 2));

Console.Write("Расстояние между точками A и B равно ");
Console.WriteLine($"{AB:f2}");

