/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.White;
    int userData = int.Parse(Console.ReadLine()!);
    Console.ResetColor();
    return userData;
}

int getExtent(int osn, int stepen)
{
    int rez = 1;
    for (int i = 0; i < stepen; i++)
    {
       rez = rez * osn;
    }
    return rez;
}

void showRezalts(string message, int number)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(message);
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Write(number);
    Console.ResetColor();
}

int a = getUserData("Ввидите первое число: ");
int b = getUserData("Ввидите второе число: ");
int rez = getExtent(a, b);
showRezalts($"{a} ^ {b} = ", rez);

