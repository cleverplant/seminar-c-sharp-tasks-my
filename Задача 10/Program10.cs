﻿/*
Задача 10: 
Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
/* защита от дурака - (range < 3 || range > 3) - диапазон 3 цифры
вопрос, как реализовать защиту от ввода символов - програмно - без интерфейса ? */

Console.WriteLine("операция по выводу второй цифры из 3-х значного числа: "); 

int number = ReadData("введите трехзначное число: "); // функция ReadData(string data) работает во блоке 2
int range = number.ToString().Length; // range - диапазон // метод -.Length - длина строки

// 1 блок - определяем диапазон___

if (range < 3 || range > 3) // зная длину строки задаем условие - диапазон три цифры 
{
    Console.WriteLine("нужно ввести трехзначное число !"); // если условие не выполняется - предупреждаем пользователя
}
else
{
    Console.WriteLine(InRange(number) + " - средний показатель по больнице"); // InRange(number) - иначе будем работать с функцией в ---> 3 блоке
}

// 2 блок - принимаем данные и возвращаем результат в консоль_____
// функция ReadData() - читаем данные

int ReadData(string data)  // data - данные
{
    Console.Write(data);
    return Convert.ToInt32(Console.ReadLine());
}
/* 
3 блок - обрабатываем 3-х значное число при условии, что 1 блок выполнен! 
и выводим среднюю цифру  
функция InRange() - возвращаем цифру стоящую в середине трехзначногно числа.
и сопровождаем текстом*/

int InRange(int AverageFigure ) // AverageFigure - средний показатель (цифра в int)
{                                                    
    int result = ((AverageFigure / 10) % 10);
    return result;
}

// вопрос, как реализовать защиту от ввода символов - програмно - без интерфейса ? 