/* Задача 67: 
Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9 */



int x = 475;


int SumNumber(int x)
{
    
if (x==0) return 0;
int rez = x%10+SumNumber(x/10);
return rez;
}

int rez = SumNumber(x);
Console.WriteLine(rez);
