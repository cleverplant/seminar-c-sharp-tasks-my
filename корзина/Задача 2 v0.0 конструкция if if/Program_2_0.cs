Console.WriteLine("В v2.0 - КОНСТРУКЦИЯ IF - IF - IF \n");

Console.Write("введите 1-е число для сравнения: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите 2-е число для сравнения: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_1 == number_2)
{
    Console.WriteLine("значения равны !"); 
    Console.WriteLine(number_1 + " == " + number_2); 
}
if (number_1 > number_2)
{
    Console.WriteLine("значения не равны !"); 
    Console.WriteLine("большее число :" + number_1); 
    Console.WriteLine("меньшее число :" + number_2);
}
if (number_1 < number_2)
{
    Console.WriteLine("значения не равны !"); 
    Console.WriteLine("большее число :" + number_2); 
    Console.WriteLine("меньшее число :" + number_1);
}
