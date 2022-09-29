/*
Задача 27:
Напишите программу, 
которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12

*/

int number = ReadInt("введите число: ");
int len = NumberLen(number);
SummaNumbers(number, len);

// Библиотека\функция ввода сообщения
int ReadInt(string StringNumber)
{
    Console.Write(StringNumber);
    return Convert.ToInt32(Console.ReadLine());
}

// считаем цифры в числе
int NumberLen(int a)
{
    int i = 0;
    while (a > 0)
    {
        a /= 10;
        i++;
    }
    return i;
}

// выводим сумму цифр в числе
void SummaNumbers(int n, int length)
{
    int summa = 0;
    for (int i = 1; i <= length; i++)
    {
        summa += n % 10;
        n /= 10;
    }
    Console.WriteLine(summa);
}


