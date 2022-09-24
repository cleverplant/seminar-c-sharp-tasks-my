/*
Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int number = ReadConsoleInput("Введите число N: ");
// цикл for - это "синтаксический сахар" от цикла while
// Циклы for и while в Си: сходство и различие посмотреть -
// https://www.youtube.com/watch?v=7K61QRBZNjM


// for (int i = 1; i <= number; i++)
// { 
//     Console.Write($"{i*i*i}  -> ");

// }
int i = 1;
while (i <= number)
{
    Console.Write($"{i*i*i}  -> ");
    i++;
}

// 
int ReadConsoleInput(string StringInInt)
{
    Console.Write(StringInInt);
    return Convert.ToInt32(Console.ReadLine());
}

