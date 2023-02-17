// 

Console.WriteLine("Введите координвту точки по x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координвту точки по y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("точка находится в первой координатной чертвети!");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("точка находится в второй координатной чертвети!");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("точка находится в nhtnmtq координатной чертвети!");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("точка находится в четвёртой координатной чертвети!");

}
else
{
    Console.WriteLine("не возможно определить координатную четверть"); 
}