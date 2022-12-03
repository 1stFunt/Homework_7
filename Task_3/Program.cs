//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] array = new int[rows, columns];
FillArray(array);
PrintImage(array);
Console.Write("Среднее арифметическое каждого столбца: ");
for (int j = 0; j < columns ; j++)
{
    double averageColumns = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        averageColumns += array[i, j];
    }
    averageColumns /= array.GetLength(0);
    averageColumns = Math.Round(averageColumns, 1);
    Console.Write(averageColumns + "; ");
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