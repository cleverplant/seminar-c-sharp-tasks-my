/* Задача 4: 
Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел. 
2, 3, 7 -> 7 
44 5 78 -> 78 
22 3 9 -> 22 
*/
Console.Write("введите 1-е число для сравнения: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите 2-е число для сравнения: ");
int number_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите 3-е число для сравнения: ");
int number_3 = Convert.ToInt32(Console.ReadLine());

int max = number_1;

if (number_2 > max)
{
    max = number_2;
}
if (number_3 > max) 
{
    max = number_3;
}
Console.Write("максимальное из 3-х чисел : " + max);

