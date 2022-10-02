void zadacha35()
{
    {
        int sise = 8;
        int[] numbers = new int[sise];/* массив создан */
        Console.WriteLine($"{sise} <- размер массива");

        FillArray(numbers);
        PrintArray(numbers);

        int MaxIndex = numbers.Length - 1;
        for (int i = 0; i < numbers.Length ; i++)
        {
            Console.WriteLine(numbers[i] + " - " + numbers[MaxIndex - i] + " ");
        }
        
    }

    void FillArray(int[] num) /* массив на заполнение */
    {
        Random vasya = new Random();
        for (int i = 0; i < num.Length; i++) //num.Length -длина массива = size 
        {
            num[i] = vasya.Next(1, 10);
        }
        Console.WriteLine();
    }

    void PrintArray(int[] numb)
    {
        for (int i = 0; i < numb.Length; i++)
        {
            Console.Write(numb[i] + ", ");
        }
        Console.WriteLine();
    }
   
}
zadacha35();
