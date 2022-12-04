Console.Clear()

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] GetArray(int m, int n)
{
    double[,] Array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Array[i, j] = new Random().NextDouble() * (100 - 0);
        }
    }
    return Array;
}
void PrintArray(double[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]:f1}  \t");
        }
        Console.WriteLine();
    }
}
Console.Write("Количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] Array = GetArray(m, n);
Console.WriteLine();
Console.WriteLine("Ваш массив:");
Console.WriteLine();
PrintArray(Array);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

