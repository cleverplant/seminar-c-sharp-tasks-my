﻿/*
Задача 38: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3,21 7,04 22,93 -2,71 78,24] -> 75,53
*/


//------------- функция ввода заполнения массива случайными DOUBLE значениями -------------------

void PrintRandomArray(int MinSize = 3, int MaxSize = 9)
{
    Random vasya = new Random();
    int size = vasya.Next(MinSize, MaxSize);
    double[] numbers = new double[size];/* массив double создан */

    Console.WriteLine();
    Console.WriteLine($"{size} <- такой размер массива сейчас");
    Console.WriteLine();

    // ---------------------------------------------------------------------------

    FillArray(numbers); // метод FillArray(); надо вызывать здесь ->           
    PrintArray(numbers); // где в контексте есть вызываемый массив - numbers !!!
    MaxMinDelta(numbers);
    // ----------------------------------------------------------------------------
    //------------Библиотека реал\Max_Min_Array_Value----

    
    void MaxMinDelta(double[] num)
    {
        double min = Int32.MaxValue;//
        double max = Int32.MinValue;//

        for (int z = 0; z < numbers.Length; z++)
        {
            if (numbers[z] > max)
            {
                max = numbers[z];
            }
            if (numbers[z] < min)
            {
                min = numbers[z];
            }
        }
        Console.WriteLine($"max = {max}, min = {min}");
        Console.WriteLine($"max - min = {max - min} delta");
    }

    //-------------------------------------------------------------------------------------

    void FillArray(double[] num) /* ЭТО МАССИВ НА ЗАПОЛНЕНИЕ */
    {
        Random mahmud = new Random();
        for (int i = 0; i < num.Length; i++) //num.Length -длина массива = size 
        {
            num[i] = Convert.ToDouble(mahmud.Next(100, 1000)) / 100;
        }
    }
    //-------------------------------------------------------------------------------------

    void PrintArray(double[] numb)
    {
        for (int i = 0; i < numb.Length; i++)
        {
            Console.Write(numb[i] + "  ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}
PrintRandomArray();



