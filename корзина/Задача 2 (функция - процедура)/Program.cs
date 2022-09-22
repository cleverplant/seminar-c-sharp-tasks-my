/* Задача 2: 
Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее. 
a = 5; b = 7 -> max = 7 
a = 2 b = 10 -> max = 10 
a = -9 b = -3 -> max = -3 */
/*    --- VOID ---
в контексте языка С# есть методы, которые могут возвращать или не возвращать какие-то значения. 
Если метод ничего не возвращает, он называется void-методом. 
в этом случае в коде оператор return,не используется.*/  

Console.Write("введите 1-е число для сравнения: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите 2-е число для сравнения: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

MyFun(num_1, num_2);

void MyFun(int number_1 , int number_2)
{

if (number_1 > number_2)
{   
    Console.WriteLine("значения не равны !"); 
    Console.WriteLine(number_1 + " > " + number_2);
}
else if (number_2 > number_1)
{   
    Console.WriteLine("значения не равны !"); 
    Console.WriteLine(number_2 + " > " + number_1);
}
else
{   
    Console.WriteLine("значения равны !");
    Console.WriteLine(number_2 + " == " + number_1);
}
}



