//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] Create2DRandomArray (int rows, int columns)
// {
//     double[,] newArray = new double[rows,columns];
//     for(int i = 0; i < rows; i++)
//       {
//          for(int j = 0; j < columns; j++)
//        {
//          newArray[i,j] = Convert.ToDouble(new Random().Next(-100, 100))/10;
//        }
//       }
//       return newArray;
// }

// void Show2dArray (double[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//       {
//          for(int j = 0; j < array.GetLength(1); j++)
//        {
//          Console.Write(array[i,j]+" ");
//        }
//         Console.WriteLine();
//       }
// }
// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] myArray = Create2DRandomArray (m,n);
// Show2dArray(myArray);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows,columns];
//     for(int i = 0; i < rows; i++)
//       {
//          for(int j = 0; j < columns; j++)
//        {
//          newArray[i,j] = new Random().Next(minValue,maxValue+1);
//        }
//       }
//       return newArray;
// }

// void Show2dArray (int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//       {
//          for(int j = 0; j < array.GetLength(1); j++)
//        {
//          Console.Write(array[i,j]+" ");
//        }
//         Console.WriteLine();
//       }
// }

// void WhatNumber (int[,] array, int a, int b)
// {
//         if (a< array.GetLength(0) && b<array.GetLength(1))
//         Console.WriteLine($"Заданное число {array.GetValue(a,b)}");
//         else
//         Console.WriteLine("Такого числа нет в массиве");

// }



// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray (m,n, min, max);
// Show2dArray(myArray);
// Console.WriteLine();
// Console.WriteLine("Введите индекс нужной строки");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите индекс нужного столбца");
// int y = Convert.ToInt32(Console.ReadLine());
// WhatNumber(myArray, x, y);

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// int[,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows,columns];
//     for(int i = 0; i < rows; i++)
//       {
//          for(int j = 0; j < columns; j++)
//        {
//          newArray[i,j] = new Random().Next(minValue,maxValue+1);
//        }
//       }
//       return newArray;
// }

// void Show2dArray (int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//       {
//          for(int j = 0; j < array.GetLength(1); j++)
//        {
//          Console.Write(array[i,j]+" ");
//        }
//         Console.WriteLine();
//       }
// }

// void ArithmeticMean (int [,] array)
// {
//  for(int j = 0; j < array.GetLength(1); j++)
//       {
//         double sum = 0;
//          for(int i = 0; i < array.GetLength(0); i++)
//        {
//          sum = array[i,j]+sum;
//        }
//         Console.WriteLine ($"Среднее арифметическое в {j+1} столбце равно {sum/array.GetLength(0)}");
//       }

// }

// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray (m,n, min, max);
// Show2dArray(myArray);
// ArithmeticMean(myArray);