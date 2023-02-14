int number = Random.Shared.Next(10, 100);
Console.WriteLine(number);
int lastDigit = number % 10;
int firstDigit = number / 10;
if (firstDigit > lastDigit)
{
    Console.WriteLine(firstDigit);
}
else
{
    Console.WriteLine(lastDigit);
}
// Console.WriteLine($"max {firsDigit}, min {lastDigit}");