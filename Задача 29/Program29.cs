/*
Задача 29: Напишите программу, 
которая задаёт массив из 8 случайных целых чисел 
и выводит отсортированный по модулю массив.

-2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19] 
6, 1, -33 -> [1, 6, -33]
*/
// шпаргалка ... Библиотека\функция пустой массив

// Сортировка одномерного массива
//int[] arr = { 6, 1, -33 };
int[] arr = { -2, 1, 7, 5, 19, 8 }; // [1, -2, 5, 7, 19] 

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
            if (Math.Abs(array[j]) < Math.Abs(array[minPosition])) // здесь ищем минимальный элемент
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



