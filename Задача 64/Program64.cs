/*
Задача 64: Задайте значения M и N. Напишите рекурсивный метод, 
который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
M = 1; N = 9. -> "3, 6, 9"          M = 13; N = 20. -> "15, 18"
*/

void Recursion() // смысл - ОТКАЗАТЬСЯ ОТ ГЛОБАЛЬНЫХ ДАННЫХ (переменных) !!!
{
    Console.WriteLine();
    Console.WriteLine("Задайте значение m : ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Задайте значение n : ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    Natural(m, n);

    void Natural(int n, int m)
    {
        m++;
        if (m % 3 == 0)
        {
            Console.WriteLine(m);
        }
        if (m > n)
        {
            return;
        }
        Natural(n, m);
    }
    Console.WriteLine();
}
Recursion();





