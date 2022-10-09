﻿/*
Задача 47: Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами, 
округлёнными до одного знака.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

void Round()
{

    Console.WriteLine("введите количество строк");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите количество столбцов");
    int columns = Convert.ToInt32(Console.ReadLine());

    double[,] numbers = new double[rows, columns];

    FillArray(numbers);
    PrintArray(numbers);

    void FillArray(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;// ну или функцию округления,КАК В 38 - num[i] = Math.Round((mahmud.NextDouble() * 20), 1); 
            }
        }
    }

    void PrintArray(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {

            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
Round(); 

