/*
Задача 2: 
Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее. 
a = 5; b = 7 -> max = 7 
a = 2 b = 10 -> max = 10 
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("\n");
Console.Write("введите 1-е число для сравнения: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите 2-е число для сравнения: ");
int b = Convert.ToInt32(Console.ReadLine());
MyFun(a, b);
void MyFun(int arg_1 , int arg_2)
{
    int max = arg_1;
    int min = arg_1;
    
    if (arg_1 > max)  max = arg_1; 
    if (arg_2 > max)  max = arg_2;
    Console.WriteLine("максимальное " + max);
    if (arg_1 < min)  min = arg_1;
    if (arg_2 < min)  min = arg_2;     
    Console.WriteLine("минимальное " + min);
    if (max == min) 
    Console.WriteLine("значения равны");
    return ;
}



