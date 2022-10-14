/*
Задача 42: 
Напишите программу, которая будет преобразовывать десятичное число в двоичное.

45 -> 101101
3 -> 11
2 -> 10

эта задача из 6 семинара
*/

void zadacha42_1()
{
int number = 43;
string result = "";
while (number > 0)
{
    result = number%2 + result;
    number /= 2;
}
Console.WriteLine(result);

} 
zadacha42_1();


void zadacha42_2()
{
int number = 43;
string result = Convert.ToString(number, 2);
Console.WriteLine(result);    
} 
zadacha42_2();





