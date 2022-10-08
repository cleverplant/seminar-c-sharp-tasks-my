/*
Задача 41
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь

0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

//---- функция ввода заполнения массива из консоли ---Библиотека одномерные массивы\Fill_Print_Console_Array
//--------------------------------------------------------------------------------------------

void PrintConsoleArray()
{
    //--- немного апгейда - изучаем CLASS ----------------------------------------------------- 
    //--- будет выводиться время --------------------------------------------------------------
    //using HelpMe; 
    // если раскоментировать using HelpMe; то можно обращатьс: 
    // TimeClass.Text(); - TimeClass.Clock(); - TimeClass.Data();

    Console.WriteLine();
    Timing.TimeClass.Text();
    Timing.TimeClass.Clock();
    Timing.TimeClass.Data();

    //--- функция ввода сообщения ( Библиотека одномерные массивы\Input_Massege_Str_Int ) ----------
    //-----------------------------------------------------------------------------------------------

    Console.WriteLine();
    int size = ReadInt("введите размер массива: ");
    Console.WriteLine();

    int ReadInt(string ReadStr)
    {
        Console.Write(ReadStr);
        return Convert.ToInt32(Console.ReadLine());
    }

    //---- создаем массив -----------------------------------------------------------------------------
    int[] numbers = new int[size];/* массив создан */
    Console.WriteLine($"{size} <- это размер массива ");
    Console.WriteLine();

    //---- вызываем методы заполнения и печати массива -----------

    ConsoleArray(numbers); // 
    PrintArray(numbers); // 
    SumValue(numbers); //
    
    //---- массив на заполнение с консоли ----( Библиотека одномерные массивы\Fill_Print_Console_Array )---------------------
    //--------------------------------------------------------------------------------------------------------

    void ConsoleArray(int[] numbe)
    {
        for (int i = 0; i < numbe.Length; i++) //
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
    Console.WriteLine();

    void SumValue(int[] num)
    {
        int sum = 0;
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] > 0)
            {
                sum++;
            }
        }
        Console.WriteLine();
        Console.WriteLine($"введено чисел больше 0 = {sum}");
    }

}
PrintConsoleArray();