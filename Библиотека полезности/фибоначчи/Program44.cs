/*
Задача 44: 
Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.

Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

void zadacha44()
{
    Console.WriteLine("введите число N ");

    int size = Convert.ToInt32(Console.ReadLine());
    int a = 0;
    int b = 1;
    double[] numbers = new double[size];
    numbers[0] = a;
    numbers[1] = b;
    for (int i = 2; i < numbers.Length; i++)
    {
        numbers[i] = numbers[i - 2] + numbers[i - 1];
    }
    //PrintArray(numbers);
    PrintArray2(numbers);

    void PrintArray(int[] numb)  // с инт идет переполнение и выдается всякая фигняюю с отрицательными числами...
    {
        for (int i = 0; i < numb.Length; i++)
        {
            Console.Write(numb[i] + ", ");
        }
        Console.WriteLine();
    }
    void PrintArray2(double[] numb)
    {
        for (int i = 0; i < numb.Length; i++)
        {
            Console.Write(numb[i] + ", ");
        }
        Console.WriteLine();
    }
}
zadacha44();







