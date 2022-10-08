

void PrintRandomArray()
{
    int size = 9;// numbers.Length;
    int[] numbers = new int[size];/* массив создан */


    Console.WriteLine();
    Console.WriteLine($"{size} <- такой размер массива сейчас");
    Console.WriteLine();

    // ---------------------------------------------------------------------------

    FillArray(numbers); // метод FillArray(); надо вызывать здесь ->           
    PrintArray(numbers); // где в контексте есть вызываемый массив - numbers !!!
    
    //-------------------------------------------------------------------------------------

    void FillArray(int[] num) /* ЭТО МАССИВ НА ЗАПОЛНЕНИЕ */
    {
        Random vasya = new Random();
        for (int i = 0; i < num.Length; i++) //num.Length -длина массива = size 
        {
            num[i] = vasya.Next(1, 115);
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



