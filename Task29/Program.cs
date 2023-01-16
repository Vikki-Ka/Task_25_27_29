/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.White;
    int userData = int.Parse(Console.ReadLine()!);
     Console.ResetColor();
    return userData;
}

int [] getRandomArrey (int length)
{
    int [] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

void showArray(int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
       Console.Write(array[i] + "," + " "); 
    }
    Console.Write("\x1B[1D");  // перемещаем курсор на 1 влево
    Console.Write("\x1B[1P");   // удаляем 1 символ
    Console.Write("\x1B[1D");
    Console.Write("\x1B[1P");
    Console.Write("]");

}

int len = getUserData("Ввидите длину массива: ");
int [] arr = getRandomArrey(len);
showArray(arr);