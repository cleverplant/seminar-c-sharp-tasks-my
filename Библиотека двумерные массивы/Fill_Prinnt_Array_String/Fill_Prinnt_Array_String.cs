/*

*/

// ---------------------------------------------------------------------------
string[,] table = new string[10, 6];

Console.WriteLine();
Console.WriteLine($"{table.GetLength(0)} <- размер массива строк");
Console.WriteLine($"{table.GetLength(1)} <- размер массива столбцов");
Console.WriteLine();

PrintArray(table);

void PrintArray(string[,] matr)
{
    for (int rows = 0; rows < table.GetLength(0); rows++)
    {
        for (int columns = 0; columns < table.GetLength(1); columns++)
        {
            Console.Write($"{table[rows, columns]} $ ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}












