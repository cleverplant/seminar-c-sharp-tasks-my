/*
Тест Роршаха — психодиагностический тест для исследования личности, 
опубликован в 1921 году швейцарским психиатром и психологом Германом Роршахом 
(нем. Hermann Rorschach). Известен также под названием «пятна Роршаха».

надо почитать библиотеку, чтобы вывести смещение в цикле (не получается)

*/


int rows = 11;
int columns = 11;

int[,] numbers = new int[rows, columns];

//Console.Clear();

Console.WriteLine();
Console.WriteLine($"картинка: {rows} x {columns}");
Console.WriteLine();

FillArray(numbers);
Console.WriteLine();
// PrintArray(numbers);
// Console.WriteLine();
PrintImage(numbers);
Console.WriteLine();

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == 0)
            {
                //Console.SetCursorPosition(0, 5);
                Console.Write($"  ");
            }
            else
            {
                //Console.SetCursorPosition(0, 5);
                Console.Write($"  @");
            }
        }
        // Console.SetCursorPosition(0, 5);
        Console.WriteLine();
    }

}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 2);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "   ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("----");
}

// Console.SetCursorPosition(10, 0);
// Console.WriteLine("+++++++++");

