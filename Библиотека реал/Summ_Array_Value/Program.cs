/*
Задача 31:
Задайте массив из 12 элементов, 
заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.

Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/
void zadacha31()
{
    {
        int sise = 12;
        int[] numbers = new int[sise];/* массив создан */
        Console.WriteLine($"{sise} <- такой размер массива сейчас");
     
        FillArray(numbers);
        PrintArray(numbers);

        Console.WriteLine(SumPositive(numbers) + " <- сумма + "); // имеет значение куда поставили
        Console.WriteLine(SumNegativ(numbers) + " <- сумма - "); // ! после FillArray ! 
    }
    int SumPositive(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++) //num.Length -длина массива = size 
        {
            if (numbers[i] > 0)
                sum = numbers[i];
        }
        return sum;
    }

    int SumNegativ(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++) //num.Length -длина массива = size 
        {
            if (numbers[i] < 0)
                sum = sum + numbers[i];
        }
        return sum;
    }

    void FillArray(int[] num) /* массив на заполнение */
    {
        Random vasya = new Random();
        for (int i = 0; i < num.Length; i++) //num.Length -длина массива = size 
        {
            num[i] = vasya.Next(-9, 10);
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
}
zadacha31();