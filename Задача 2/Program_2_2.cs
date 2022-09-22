/* Задача 2: 
Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее. 
a = 5; b = 7 -> max = 7 
a = 2 b = 10 -> max = 10 
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("В v2.0 - КОНСТРУКЦИЯ IF - ELSE IF - ELSE \n");

Console.Write("введите 1-е число для сравнения: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите 2-е число для сравнения: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_1 > number_2)
{   
    Console.WriteLine("значения не равны !"); 
    Console.WriteLine(number_1 + " больше " + number_2);
}
else if (number_2 > number_1)
{   
    Console.WriteLine("значения не равны !"); 
    Console.WriteLine(number_2 + " больше " + number_1);
}
else
{   
    Console.WriteLine("значения равны !");
    Console.WriteLine(number_2 + " равно " + number_1);
}

