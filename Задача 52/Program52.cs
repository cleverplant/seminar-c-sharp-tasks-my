
/*
Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 5 3
8 4 6 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 6; 3.
*/

// Надо эту задачку закинуть в бибку полезности! - перебор столбцов-потом найти перебор строк и тоже закинуть!
// перебор по строкам - j   перебор по столбцам - i

Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];

FillArray(numbers);
PrintArray(numbers);
PrintArithmeticMean(numbers);


void PrintArithmeticMean(int[,] array)
{
    for (int j = 0; j < numbers.GetLength(1); j++)// rows
    {
        double ArithmeticMean = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)// columns 
        {
            ArithmeticMean = (ArithmeticMean + numbers[i, j]);
        }
        ArithmeticMean = ArithmeticMean / n;
        Console.WriteLine(ArithmeticMean +  "\t  <- Arithmetic mean of columns");
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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

