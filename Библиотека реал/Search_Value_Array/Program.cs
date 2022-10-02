/*
Задача 33:

Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
*/

void zadacha33()
{
    {
        int check = 5;
        int sise = 6;
        int[] numbers = new int[sise];/* массив создан */
        Console.WriteLine($"{sise} <- размер массива");
        Console.WriteLine($"{check} <- ищем это число");

        FillArray(numbers);
        PrintArray(numbers);
        Check(numbers, check);
        //CheckArray(numbers, check);
    }

    void FillArray(int[] num) /* массив на заполнение */
    {
        Random vasya = new Random();
        for (int i = 0; i < num.Length; i++) //num.Length -длина массива = size 
        {
            num[i] = vasya.Next(-3, 7);
        }
    }

    void PrintArray(int[] numb)
    {
        for (int i = 0; i < numb.Length; i++)
        {
            Console.Write(numb[i] + ", ");
        }
        Console.WriteLine();
    }

    void CheckArray(int[] numbers, int check)
    {
        bool flag = false;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == check)
                flag = true;// лучше писать просто flag - он и так true - он сам и есть true
            // if (numbers[i] == check)
            // c
            // if (numbers[i] == check)
            // Console.WriteLine("число НЕ найдено");
        }
        if (flag == true)
            Console.WriteLine("число найдено");
        else
            Console.WriteLine("число НЕ найдено");
    }

    void Check(int[] numbers, int check)
    {
        bool flag = false;
        int i = 0;
        while (!flag && i < numbers.Length)//! это отрицание - типа NOT
        {
            if (numbers[i] == check)
            {
                flag = true;
            }
            i++;
        }
        if (flag)//писать просто flag - он и так true - он сам и есть true
            Console.WriteLine("число найдено");
        else
            Console.WriteLine("число НЕ найдено");
    }
}

zadacha33();



