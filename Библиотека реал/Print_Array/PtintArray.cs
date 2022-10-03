
//------------- функция заполнения массива значениями -------------------
//using HelpMe;

Timing.TimeClass.Clock();
Timing.TimeClass.Data();

void PrintArray()
{
    int[] numbers = { 3, 21, 7, 4, 22, 93, 2, 71 };
    int size = numbers.Length;

    Console.WriteLine();
    Console.WriteLine($"{size} <- размер массива ");
    Console.WriteLine();
    // --------------------------------------------------------------------------
    // Массив уже создан и заполнять нечего, поэтому никаких ФиллЭреев не нужно !!!
    // ---------------------------------------------------------------------------
    
    PrintArray(numbers); // где в контексте есть вызываемый массив - numbers !!!

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
PrintArray();
