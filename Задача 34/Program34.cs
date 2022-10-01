/*
Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
//--- на основе ---> Библиотека реал\Fill_Print_Random_Array

//------------- функция ввода заполнения массива случайными значениями -------------------

void PrintRandomArray(int MinSize = 1, int MaxSize = 9, int MinFill = 100, int MaxFill = 1000)
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
            int count = 0;
            for (int meaning = 0; meaning < bers.Length; meaning++)
                if (bers[meaning] % 2 == 0)
                    count++;

            Console.WriteLine($"из {bers.Length} чисел, {count} четных ");
            Console.WriteLine();
        }
    }

}
PrintRandomArray();






