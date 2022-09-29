/*
Задача 25: 
Используя определение степени числа, напишите цикл, 
который принимает на вход два натуральных числа (A и B) 
и возводит число A в степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int numberA = ReadInt("введите число A: ");
int numberB = ReadInt("введите число B: ");
ToDegree(numberA, numberB);

// в степень
void ToDegree(int x, int y)
{
    int result = 1;
    for (int i = 1; i <= y; i++)
    {
        result = result * x;
    }
    Console.WriteLine(result);
}

//  Библиотека\функция ввода сообщения
int ReadInt(string StringNumber)
{
    Console.WriteLine(StringNumber);
    return Convert.ToInt32(Console.ReadLine());
}

