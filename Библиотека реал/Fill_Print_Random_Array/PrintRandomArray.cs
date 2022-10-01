//------------- функция ввода заполнения массива случайными значениями -------------------

void PrintRandomArray(int MinSize = 1, int MaxSize = 9, int MinFill = 0, int MaxFill = 2)
{
    Random vasya = new Random();
    int size = vasya.Next(MinSize, MaxSize);
    int[] numbers = new int[size];/* массив создан */

    Console.WriteLine();
    Console.WriteLine($"{size} <- такой размер массива сейчас");
    Console.WriteLine();

    // ---------------------------------------------------------------------------

    FillArray(numbers, MinFill, MaxFill); // метод FillArray(); надо вызывать здесь ->           
    PrintArray(numbers); // где в контексте есть вызываемый массив - numbers !!!

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
            Console.Write(numb[i] + ", ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}

PrintRandomArray();
