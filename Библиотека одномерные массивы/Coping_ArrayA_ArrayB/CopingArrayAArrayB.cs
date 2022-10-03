

void CopingRandomArray()
{
    int size = 9;
    int[] numbers1 = new int[size];/* массив создан */
    int[] numbers2 = new int[size];

    Console.WriteLine();
    Console.WriteLine($"{size} <- такой размер массива сейчас");
    Console.WriteLine();

    // ---------------------------------------------------------------------------
    FillArray(numbers1);
    PrintArray(numbers1);
    CopingArray(numbers1, numbers2);
    PrintArray(numbers2);
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
    //--------------------------------------------------
    void CopingArray(int[] numb1, int[] numb2)
    {
        for (int i = 0; i < numb2.Length; i++)
        {
            numb2[i] = numb1[i];
        }
    }
    Console.WriteLine();
}
CopingRandomArray();

