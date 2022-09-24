/*
Задача 21 
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int x1 = ReadConsoleInput("Введите координату X первой точки: ");
int y1 = ReadConsoleInput("Введите координату Y первой точки: ");
int z1 = ReadConsoleInput("Введите координату Z первой точки: ");
int x2 = ReadConsoleInput("Введите координату X второй точки: ");
int y2 = ReadConsoleInput("Введите координату Y второй точки: ");
int z2 = ReadConsoleInput("Введите координату Z второй точки: ");

int XX = x2 - x1;
int YY = y2 - y1;
int ZZ = z1 - z2;

double length = Math.Sqrt(XX * XX + YY * YY + ZZ * ZZ);
Console.WriteLine($"расстояние между координатами двух точек в 3D пространстве == {length}");
Console.WriteLine();
//
int ReadConsoleInput(string StringInInt)
{
    Console.Write(StringInInt);
    return Convert.ToInt32(Console.ReadLine());
}
