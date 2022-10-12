/*
Задача 61: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/

Console.Clear();
Console.WriteLine("----");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("находим произведение двух матриц");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("введите размер квадратного массива");
int RowsColumns = Convert.ToInt32(Console.ReadLine());

int[,] numbersA = new int[RowsColumns, RowsColumns];
int[,] numbersB = new int[RowsColumns, RowsColumns];
int[,] numbersC = new int[RowsColumns, RowsColumns];

Console.WriteLine("----");
Console.ForegroundColor = ConsoleColor.Green;
FillArray(numbersA);
PrintArray(numbersA);
//Console.WriteLine("-1--");
Console.ForegroundColor = ConsoleColor.Blue;
FillArray(numbersB);
PrintArray(numbersB);
//Console.WriteLine("-2--");
Console.ForegroundColor = ConsoleColor.Yellow;
ResultArray(numbersA, numbersB, numbersC);
PrintArray(numbersC);
Console.ForegroundColor = ConsoleColor.Green;
//Console.WriteLine("-3--");
Console.Beep();

void ResultArray(int[,] arrayA, int[,] arrayB, int[,] arrayC)
{
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            arrayC[i, j] = 0;
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
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
            array[i, j] = new Random().Next(1, 5);
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











