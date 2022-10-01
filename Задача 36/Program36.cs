/*
Задача 36. 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов с нечётными индексами.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
//--- на основе ---> Библиотека реал\Fill_Print_Random_Array

//------------- функция ввода заполнения массива случайными значениями -------------------

void PrintRandomArray(int MinSize = 5, int MaxSize = 6, int MinFill = 1, int MaxFill = 100)
{
    Random vasya = new Random();
    int size = vasya.Next(MinSize, MaxSize);
    int[] numbers = new int[size];/* массив создан */

    Console.WriteLine();
    Console.WriteLine($"{size} <- такой размер массива сейчас");
    Console.WriteLine();

    // ---------- вызываем все методы ------------------------------------------------------

    FillArray(numbers, MinFill, MaxFill); // методы надо вызывать здесь ->           
    PrintArray(numbers); // где в контексте есть вызываемый массив - numbers !!!
    Console.WriteLine();
    Parsing(numbers);
    //-------------------------------------------------------------------------------------

    void FillArray(int[] num, int Min, int Max) /* ЭТО МАССИВ НА ЗАПОЛНЕНИЕ */
    {
        Random vasya = new Random();
        for (int i = 0; i < num.Length; i++) //num.Length -длина массива = size 
        {
            num[i] = vasya.Next(Min, Max);
        }
    }

    //-------------------------------------------------------------------------------------

    void PrintArray(int[] numb)
    {
        for (int i = 0; i < numb.Length; i++)
        {
            Console.Write($"{numb[i]}, ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();

    //-----функция парсинга/разбора на четность---------------------------------------------------

    void Parsing(int[] bers)
    {
        {
            int sum = 0;
            for (int meaning = 1; meaning < bers.Length; meaning += 2)
            {
                sum += bers[meaning];

            }
            Console.WriteLine($"всего {numbers.Length} элемента, сумма элементов с нечётными индексами {sum}");
        }
    }
}
PrintRandomArray();




