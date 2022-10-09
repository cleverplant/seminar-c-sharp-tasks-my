/*
Задача 50:Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 3->3
*/

Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[8, 8];
// по простому - без рандомов - фиксируем жестко - времени нет - сдаем дз до семинара

FillArray(numbers);
PrintArray(numbers);
Array(numbers, n, m);

void Array(int[,] array, int n, int m)
{
    if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
    {
        Console.WriteLine("такого элемента нет");
    }
    else
    {
        Console.WriteLine($"элемент {n} строки ");
        Console.WriteLine($"элемент {m} столбца");
        Console.WriteLine($"значение -> {numbers[n - 1, m - 1]}");
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) / 10;
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
}

