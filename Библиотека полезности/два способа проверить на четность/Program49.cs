/*
[Задача 49:]()

Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив    Новый массив будет выглядеть
выглядел вот так:              вот так:
1 4 7 2                            1 4 7 2
5 9 2 3                            5 812 9
8 4 2 4                            8 4 2 4
 ЧЁ НЕ ТАК - ПОТОМ ДОПИЛЮ
*/


void PrintRandomArray()
{
    int[,] matrix = new int[3, 4];

    Console.WriteLine();
    Console.WriteLine($"{matrix.GetLength(0)} <- размер массива строк");
    Console.WriteLine($"{matrix.GetLength(1)} <- размер массива столбцов");
    Console.WriteLine();

    //PrintArray(matrix);
    FillArray(matrix);
    PrintArray(matrix);
    //CheckArray(matrix);
    //PrintArray(matrix);
    CheckArray2(matrix);
    PrintArray(matrix);

    // ---------------------------------------------------------------------------
    void FillArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i += 2)
        {
            for (int j = 0; j < matr.GetLength(1); j += 2)
            {
                matr[i, j] = new Random().Next(1, 10);// 
            }
            //Console.WriteLine();
        }
        Console.WriteLine();
    }

    void PrintArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)// rows - строки
        {
            for (int j = 0; j < matr.GetLength(1); j++)// columns -столбцы
            {
                Console.Write($"{matr[i, j] + " "}");// 
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine(" =============================");

    void CheckArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)// rows - строки
        {
            for (int j = 0; j < matr.GetLength(1); j++)// columns -столбцы
            {
                if (matr[i, j] % 2 == 0)
                    matr[i, j] = matr[i, j] * matr[i, j];
            }
            Console.WriteLine("+++++++++++++++++++++++++++++");
        }
    }

    void CheckArray2(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i += 2)// rows - строки
        {
            for (int j = 0; j < matr.GetLength(1); j += 2)// columns -столбцы
            {

                matr[i, j] = matr[i, j] * matr[i, j];
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine("------------------------------------");

}
PrintRandomArray();





