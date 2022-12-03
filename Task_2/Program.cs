// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
while (true)
{
    int rows = 6; int columns = 5;
    int[,] array = new int[rows, columns];
    int number = ReadInt("Введите двухзначное число: ");
    int a = 0; int b = 0;
    if (number > 9 && number < 100)
    {
        a = number / 10; b = number % 10;
        if (a < rows && b < columns)
        {
            FillArray(array); PrintImage(array);
            Console.WriteLine($"{number} -> {array[a, b]}");
        }
        else
        {
            FillArray(array); PrintImage(array);
            Console.WriteLine($"{number} -> такого числа не существует");
        }
    }
    else
    {
        Console.WriteLine("Вы ввели не двухзначное число!");
        continue;
    }
    break;
}

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            Console.Write($"{image[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}