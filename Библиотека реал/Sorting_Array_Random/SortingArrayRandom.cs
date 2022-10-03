

//------------- функция сортировки массива со случайными значениями -------------------

void PrintRandomArray()
{
    int size = 6;

    int[] numbers = new int[size];/* массив создан */


    Console.WriteLine();
    Console.WriteLine($"{size} <- такой размер массива сейчас");
    Console.WriteLine();

    // ---------------------------------------------------------------------------

    FillArray(numbers); // метод FillArray(); надо вызывать здесь ->           
    PrintArray(numbers); // где в контексте есть вызываемый массив - numbers !!!
    SortingArray(numbers);
    PrintArray(numbers);
    //-------------------------------------------------------------------------------------

    void FillArray(int[] num) /* ЭТО МАССИВ НА ЗАПОЛНЕНИЕ */
    {
        Random vasya = new Random();
        for (int i = 0; i < num.Length; i++) //num.Length -длина массива = size 
        {
            num[i] = vasya.Next(1, 15);
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

    void SortingArray(int[] num)
    {
        int size = num.Length;
        for (int i = 1; i < size; i++)
        {
            for (int j = 0; j < size - i; j++)
            {
                if (num[j] > num[j + 1])
                {
                    int tmp = num[j];// 
                    num[j] = num[j + 1];//  
                    num[j + 1] = tmp;// 
                }
            }
        }
    }




}

PrintRandomArray();



