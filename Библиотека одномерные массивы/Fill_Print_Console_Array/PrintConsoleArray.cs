//------------- функция ввода заполнения массива из консоли -------------------

void PrintConsoleArray()
{
    //--- функция ввода сообщения ( Библиотека реал\Input_Massege_Str_Int ) ----------

    int size = ReadInt("введите размер массива: ");

    int ReadInt(string ReadStr)
    {
        Console.Write(ReadStr);
        return Convert.ToInt32(Console.ReadLine());
    }
    //---- создаем массив ---------------------------------------------------------------

    int[] numbers = new int[size];/* массив создан */
    Console.WriteLine($"{size} <- это размер массива ");
    Console.WriteLine();

    //---- вызываем методы заполнения и печати массива -------------------------------------------------------

    ConsoleArray(numbers); // <- метод ConsoleArray(numbers) и PrintArray(); надо вызывать здесь
    PrintArray(numbers); // <- где в контексте есть вызываемый массив - numbers !!!

    //---- массив на заполнение с консоли ------------------------------------------------

    void ConsoleArray(int[] numbe)
    {
        for (int i = 0; i < numbe.Length; i++) //num.Length -длина массива = size 
        {
            Console.WriteLine($"введите {i + 1}-й элемент массива: ");
            numbe[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
    }
    //---- массив выводим на печать -------------------------------------------------------
    
    void PrintArray(int[] numb)
    {
        for (int i = 0; i < numb.Length; i++)
        {
            Console.Write(numb[i] + ", "); // это массив на вывод
        }
        Console.WriteLine();
    }
}
PrintConsoleArray();





