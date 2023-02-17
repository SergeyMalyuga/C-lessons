// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
// AB = √(xb - xa)2 + (yb - ya)2

Console.WriteLine("Введите координату точки a по x");
double ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки a по y");
double ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки b по x");
double bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки b по y");
double by = Convert.ToInt32(Console.ReadLine());


double ab = Math.Pow(ax-bx,2)+Math.Pow(ay-by,2);
Console.WriteLine(ab);

ab = Math.Sqrt(ab);
Console.WriteLine($"{ab:f2}");
