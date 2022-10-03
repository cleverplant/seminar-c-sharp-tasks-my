

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
   for (int i = 0; i < size - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < size; j++)
        {
            if (num[j] < num[minPosition]) // здесь ищем минимальный элемент
            minPosition = j;
        }
        // смысл кода ниже надо поменять minPosition = i; которую нашли ранее на
        int tmp = num[i];// i = 0 записываем на временное хранение в tmp, а когда записали, то затем в нее
        num[i] = num[minPosition];//  записываем  minPosition = j; (обмен переменных местами)   
        num[minPosition] = tmp;// 
    }
}

PrintArray(numbers);
SortingArray(numbers);
PrintArray(numbers);