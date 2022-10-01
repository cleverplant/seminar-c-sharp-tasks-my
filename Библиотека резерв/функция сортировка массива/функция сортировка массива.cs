// Сортировка одномерного массива

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) // здесь ищем минимальный элемент
            minPosition = j;
        }
        // смысл кода ниже надо поменять minPosition = i; которую нашли ранее на
        int tmp = array[i];// i = 0 записываем на временное хранение в tmp, а когда записали, то затем в нее
        array[i] = array[minPosition];//  записываем  minPosition = j; (обмен переменных местами)   
        array[minPosition] = tmp;// 
    }

}


PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

