/*

*/

// -------   НАРОДНАЯ ИГРА - КАЛЕЙДОСКОП   ---------------------------------------------


string[,] table = new string[10, 10];

Console.WriteLine();
Console.WriteLine($"{table.GetLength(0)} <- размер массива строк");
Console.WriteLine($"{table.GetLength(1)} <- размер массива столбцов");
Console.WriteLine();

FillArray(table);
PrintArray(table);


void FillArray(string[,] matr)//заполняем массив 
{
    Random mahmud = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Convert.ToString(mahmud.Next(0, 2));//заполняем массив рандомными 0 и 1
        }
    }
}


void PrintArray(string[,] matr)//выводим на печать массив 0 и 1 
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($" {matr[rows, columns]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintImage(string[,] image)// разукрашиваем массив собаками
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == "0")
                Console.Write($"   ");//если 0 пропускаем печать

            else Console.Write($" @ ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
PrintImage(table);













