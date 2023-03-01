// Задача №43. 
// Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 
 double inputData (String messageToUser)
 {
    Console.Write(messageToUser);
    String answer = Console.ReadLine();
    double.TryParse (answer, out double number);
    return number;
 }

 void pointOfIntersection   (double a, double b, double c, double d)
 {
    double x;
    double y;
    double podouble; 
    x = (d-c)/(a-b);
    y = a*x+c;
    podouble = (a*d-b*c)/(a-b);
    Console.WriteLine();
    Console.WriteLine ($"Угловые коэффициенты: a={a}, b={b}");
    Console.WriteLine ($"Пересечение прямых с осью у: c={c}, d={d}");
    Console.WriteLine();
    Console.WriteLine ($"Точка пересечения прямых: ({x}, {podouble})");
}

double a = inputData ("Введите угловой коэффициент а: ");
double b = inputData ("Введите угловой коэффициент b: ");
double c = inputData ("Введите точку пересечения с осью у: ");
double d = inputData ("Введите точку пересечения с осью у: ");

pointOfIntersection (a,b,c,d);
