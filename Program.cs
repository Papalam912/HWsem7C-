Console.Clear();

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] GetArray(int m, int n)
// {
//     double[,] Array = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             Array[i, j] = new Random().NextDouble() * (100 - 0);
//         }
//     }
//     return Array;
// }
// void PrintArray(double[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             Console.Write($"{Array[i, j]:f1}  \t");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Write("Количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] Array = GetArray(m, n);
// Console.WriteLine();
// Console.WriteLine("Ваш массив:");
// Console.WriteLine();
// PrintArray(Array);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] GetArray(int m, int n)
// {
//     int[,] Array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             Array[i, j] = new Random().Next(0, 100);
//         }
//     }
//     return Array;
// }
// void PrintArray(int[,] Array)
// {
//     int shiftRow = 1;
//     int shiftColumn = 1;

//     Console.Write(" \t");
//     for (int k = 0; k < Array.GetLength(1); k++)
//     {
//         Console.Write($"({shiftColumn}) \t");
//         shiftColumn++;
//     }
//     Console.WriteLine();
//     Console.WriteLine();
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             if (j == 0)
//             {
//                 Console.Write($"|{shiftRow}| \t");
//                 shiftRow++;
//             }
//             Console.Write($"{Array[i, j]}  \t");
//         }
//         Console.WriteLine();
//     }
// }

// string CheckArray(int[,] Array, int row, int column)
// {
//     string result = "";
//     if (row > Array.GetLength(0) - 1 || column > Array.GetLength(1) - 1)
//         result = "Такого числа в массиве нет";
//     else
//     {
//         result = Convert.ToString(Array[row, column]);
//     }
//     return result;
// }

// Console.Write("Количество строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Количество столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] Array = GetArray(row, column);
// Console.WriteLine();
// Console.WriteLine("Ваш массив:");
// Console.WriteLine();
// PrintArray(Array);

// Console.WriteLine();
// Console.WriteLine("Поиск элемента массива по позиции: ");
// Console.WriteLine();
// Console.Write("Введите строку элемента: ");
// int rowCheck = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.Write("Введите столбец элемента: ");
// int columnCheck = Convert.ToInt32(Console.ReadLine()) - 1;
// string result = CheckArray(Array, rowCheck, columnCheck);
// Console.WriteLine();
// Console.WriteLine(result);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// int[,] GetArray(int m, int n)
// {
//     int[,] Array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             Array[i, j] = new Random().Next(0, 100);
//         }
//     }
//     return Array;
// }
// void PrintArray(int[,] Array)
// {
//     int shiftRow = 1;
//     int shiftColumn = 1;

//     Console.Write(" \t");
//     for (int k = 0; k < Array.GetLength(1); k++)
//     {
//         Console.Write($"({shiftColumn}) \t");
//         shiftColumn++;
//     }
//     Console.WriteLine();
//     Console.WriteLine();
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             if (j == 0)
//             {
//                 Console.Write($"|{shiftRow}| \t");
//                 shiftRow++;
//             }
//             Console.Write($"{Array[i, j]}  \t");
//         }
//         Console.WriteLine();
//     }
// }

// double[] AverageColumnArray(int[,] Array)
// {
//     double[] arrayAver = new double[Array.GetLength(1)];
//     for (int i = 0; i < Array.GetLength(1); i++)
//     {
//         for (int j = 0; j < Array.GetLength(0); j++)
//         {
//             arrayAver[i] += Array[j, i];
//         }
//     }
//     for (int i = 0; i < arrayAver.Length; i++)
//     {
//         arrayAver[i] /= Array.GetLength(0);
//     }
//     return arrayAver;
// }

// Console.Write("Количество строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Количество столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] Array = GetArray(row, column);
// Console.WriteLine();
// Console.WriteLine("Ваш массив:");
// Console.WriteLine();
// PrintArray(Array);

// Console.WriteLine();
// Console.Write("Среднее: ");
// double[] result = AverageColumnArray(Array);
// for (int i = 0; i < result.Length; i++)
// {
//     Console.Write($"{result[i]:f1} \t");
// }