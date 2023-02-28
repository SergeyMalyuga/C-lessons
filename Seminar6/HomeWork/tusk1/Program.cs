// Задача №41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// *задача от преподавателя *
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода слова "stop"

bool a = true;
int count = 0;
String inputData = string.Empty;
Console.WriteLine("Вводите любые целые числа. После ввода команды \"stop\"  будет произведен подсчёт положительных чисел ");
while (a)
{
    
    String answer = Console.ReadLine();
    if (int.TryParse(answer, out int num))
    {
        inputData =inputData + " " + answer;
    }
    if (num > 0)
    {
        count += 1;
    }
    if (answer == "stop")
    {
        a = false;
    }
}
Console.WriteLine();
Console.WriteLine($"{inputData.Trim( )} -> {count}");

