/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
// 

Console.Write("введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 99999)
{
    {
        while (number > 99999)
        {
            number /= 10;
        }

    }
    int a = (number / 10000);
    int b = (number % 10000) / 1000;
    int c = (number % 1000) / 100;
    int d = (number % 100) / 10;
    int e = (number % 10 / 1);
    Console.WriteLine("[ 0 ]  числа: " + a);
    Console.WriteLine("[ 1 ]  числа: " + b);
    Console.WriteLine("[ 2 ]  числа: " + c);
    Console.WriteLine("[ 3 ]  числа: " + d);
    Console.WriteLine("[ 4 ]  числа: " + e);

    if (a == e && b == d)
    {
        Console.WriteLine($"{number} - это палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - это НЕ палиндром");
    }
}


else
{
    Console.Write("ошибка. нужно вводить пятизначное число");
}

