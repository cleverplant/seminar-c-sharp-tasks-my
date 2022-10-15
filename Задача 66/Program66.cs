/*
Задача 66:Задайте значения M и N. 
Напишите рекурсивный метод, который найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

void Recursion()
{

Console.WriteLine();
Console.WriteLine("Задайте значение m : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение n : ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine(Natural(m, n));

int Natural(int m, int n, int sum = 0)
{
    if (m > n)
    {
        return sum;
    }
    sum += m;
    m++;
    return Natural(m, n, sum);
}
}
Recursion();
/*
Задача 67:Напишите программу, 
которая будет принимать на вход число и возвращать сумму его цифр.

453 -> 12
45 -> 9
*/
void task67()
{
    Console.WriteLine("Задайте число : ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(SumNum(number));

    int SumNum(int num, int sum = 0)
    {
        if (num == 0)
        {
            return sum;
        }
        sum = sum + num % 10;
        num = num / 10;
        return SumNum(num, sum);

    }
}
//task67();