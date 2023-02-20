// Задача №21.
// Напишите программу, которая принимает на вход координаты д
// вух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// ABC = √(xb - xa)2 + (yb - ya)2+(zb-za)2


int xa= Input("Введите координату точки A по x");
int ya= Input("Введите координату точки A по y");
int za= Input("Введите координату точки A по z");
int xb= Input("Введите координату точки B по x");
int yb= Input("Введите координату точки B по y");
int zb= Input("Введите координату точки B по z");

double rez = Math.Pow(xb-xa,2)+Math.Pow(yb-ya,2)+Math.Pow(zb-za,2);
rez=Math.Sqrt(rez);
Console.WriteLine($"{rez:f2}");

int Input(String messageToUser)
{
  Console.WriteLine(messageToUser);  
  String answer = Console.ReadLine();
  if (int.TryParse(answer, out int number))
  {
    return number;
  }
  else
{
    Console.WriteLine ("Вы ввели не число! "+answer);
    return number;
}  
}


