

// Сортировка одномерного массива

int[] numbers = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
int size = numbers.Length;

Console.WriteLine();
Console.WriteLine($"{size} <- размер массива");
Console.WriteLine();

void PrintArray(int[] num)
{
    int size = num.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{num[i]} ");
    }
    Console.WriteLine();
}

void SortingArray(int[] num)
{
    int size = num.Length;
    for (int i = 1; i < size; i++)
    {
        for (int j = 0; j < size - i; j++)
        {
            if (num[j] > num[j + 1])
            {
                int tmp = num[j];// 
                num[j] = num[j + 1];//  
                num[j + 1] = tmp;// 
            }
        }
    }
}

PrintArray(numbers);
SortingArray(numbers);
PrintArray(numbers);