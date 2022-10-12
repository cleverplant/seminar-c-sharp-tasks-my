/*
Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
Console.Clear();

var random = new Random();
int rows = random.Next(4, 8);
int columns = random.Next(4, 8);
int[,] array = new int[rows, columns];

Console.WriteLine();
Console.WriteLine($"массив: {rows} x {columns}");
Console.WriteLine();

FillArray(array);
Console.WriteLine();
Console.WriteLine("массив до: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("массив после: ");
SortingArray(array);
PrintArray(array);

void SortingArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int pos = 0; pos < array.GetLength(1) - 1; pos++)
            {
                if (array[i, pos] < array[i, pos + 1])
                {//по убыванию так < а по возрастанию так >

                    int temp = array[i, pos + 1];
                    array[i, pos + 1] = array[i, pos];
                    array[i, pos] = temp;
                    // int temp = 0;
                    // temp = array[i, pos];
                    // array[i, pos] = array[i, pos + 1];
                    // array[i, pos + 1] = temp;
                }
            }
        }
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
}



