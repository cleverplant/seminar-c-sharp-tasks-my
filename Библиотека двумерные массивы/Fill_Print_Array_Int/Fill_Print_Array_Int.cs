/*
// rows - строки
// columns -столбцы
*/

void PrintRandomArray()
{
    int[,] matrix = new int[3, 4];

    Console.WriteLine();
    Console.WriteLine($"{matrix.GetLength(0)} <- размер массива строк");
    Console.WriteLine($"{matrix.GetLength(1)} <- размер массива столбцов");
    Console.WriteLine();

    PrintArray(matrix);
    FillArray(matrix);
    PrintArray(matrix);
    // ---------------------------------------------------------------------------
    void FillArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = new Random().Next(1, 10);// [1; 10)
            }
        }
    }

    void PrintArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)// rows - строки
        {
            for (int j = 0; j < matr.GetLength(1); j++)// columns -столбцы
            {
                Console.Write($"{matr[i, j]} ");// 
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}
PrintRandomArray();


