/* Задача 8: 
Напишите программу, которая на вход принимает число (N > 0), 
а на выходе показывает все чётные числа от 1 до N. 
5 -> 2, 4 
8 -> 2, 4, 6, 8 
Сдайте задание до: 22 сент., 19:00 EET
*/

Console.Write("введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int run = 1;
while(run <= N)
{
    if(run % 2 == 0)
    Console.Write(run + ", ");
    run = run + 1;
}




