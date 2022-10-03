/*
Задача 43]()

Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 

значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

//----(( Библиотека одномерные массивы\Input_Massege_Str_Int )
void Coordinates()
{

    double b1 = ReadInt1("введите значение b1: ");
    double ReadInt1(string ReadStr)
    {
        Console.Write(ReadStr);
        return Convert.ToInt32(Console.ReadLine());
    }
    double k1 = ReadInt2("введите значение k1: ");
    double ReadInt2(string ReadStr)
    {
        Console.Write(ReadStr);
        return Convert.ToInt32(Console.ReadLine());
    }
    double b2 = ReadInt3("введите значение b2: ");
    double ReadInt3(string ReadStr)
    {
        Console.Write(ReadStr);
        return Convert.ToInt32(Console.ReadLine());
    }
    double k2 = ReadInt4("введите значение k2: ");
    double ReadInt4(string ReadStr)
    {
        Console.Write(ReadStr);
        return Convert.ToInt32(Console.ReadLine());
    }
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    //double y = k2 * x + b2;
    // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; - 0,5)

    Console.WriteLine($"точка пересечения двух прямых, заданных уравнениями ( {x}, ; {y} )");


}
Coordinates();

/*
y = k1 * x + b1, y = k2 * x + b2; 

k1 * x + b1 = k2 * x + b2
k1 * x - k2 * x = b2 - b1
x*(k1 - k2) = b2 - b1
x = (b2 - b1) / (k1 - k2)
---------------------------------------




*/


