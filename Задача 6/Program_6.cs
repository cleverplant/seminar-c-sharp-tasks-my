﻿/* Задача 6: 
Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка). 
4 -> да 
-3 -> нет 
7 -> нет
*/

Console.Write("Введите число : ");        // обнаружил что при введении двухзначного числа 
int a = Convert.ToInt32(Console.Read());  // ответ на 16 "нет нечетное" - все дело в Convert.ToInt32 ?
//int a = 16; // <-------------------------- если задавать так, то все работает
if (a % 2 == 0)                           // надо было спросить чЁ это - или поздняк?
{
    Console.WriteLine("да четное");
}    
else 
{
    Console.WriteLine("нет нечетное");
}







