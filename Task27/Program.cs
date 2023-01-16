/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.White;
    int userData = int.Parse(Console.ReadLine()!);
    Console.ResetColor();
    return userData;
}

int giveSumDigit(int number)
{
    // находим количество цифр в числе
    int totalDigit = 0;
    int num = number;
    while (num > 0)
    {
        num = num / 10;
        totalDigit++;
    }
    // считаем сумму цифр
    int sum = 0;
    double temp = 0;
    for (int i = 0; i < totalDigit; i++)
    {
        temp = number / Math.Pow(10, i) % 10;
        temp = Math.Truncate(temp);             // берем только целую часть
        sum = sum + (int)temp;                  // в тип данных int
    }
    return sum;
}

void showRezalts(string message, int sum)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(message);
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Write(sum);
    Console.ResetColor();
}

int number = getUserData("Ввидите число: ");
int sum = giveSumDigit(number);
showRezalts($"Сумма цифр в числе {number} = ", sum);

