﻿/*
Задача 58: Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:

01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

*/

Console.Clear();
Console.Beep();
Console.ForegroundColor = ConsoleColor.Blue; // устанавливаем цвет
//Console.ResetColor(); // сбрасываем в стандартный
//Console.BackgroundColor = ConsoleColor.Red;   // к примеру зеленый

Console.WriteLine("введите размер квадратного массива");
int RowsColumns = Convert.ToInt32(Console.ReadLine());

// int RowsColumns = 4;
int[,] numbers = new int[RowsColumns, RowsColumns];

SpiralArray(numbers);
Console.WriteLine();
PrintArray(numbers);
Console.WriteLine();

void SpiralArray(int[,] array)
{
    int num = 1;
    int i = 0;
    int j = 0;

    while (num <= RowsColumns * RowsColumns)
    {
        array[i, j] = num;

        if (i <= j + 1 && i + j < RowsColumns - 1)

        {
            ++j;
        }
        else if (i < j && i + j >= RowsColumns - 1)
        {
            ++i;
        }

        else if (i >= j && i + j > RowsColumns - 1)
        {
            --j;
        }

        else
            --i;
        ++num;
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("----");
    Console.Beep();
}

