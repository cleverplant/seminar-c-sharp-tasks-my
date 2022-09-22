/*
Задача 15: 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int DayWeek = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(OurLife(DayWeek));

int ReadInt(string ReadFromConsole)
{
    Console.Write(ReadFromConsole);
    return Convert.ToInt32(Console.ReadLine());
}

/* возвращаю - "хорошего дня! по завершению работы :) */
string OurLife(int weekend)
{
    if (weekend > 0 && weekend < 8)
    {
        if (weekend == 7 || weekend == 6)
        {
            Console.WriteLine(weekend + " сегодня выходной");
            Console.WriteLine("сегодня будет праздник!");
        }
        else if (weekend == 1)
        {
            Console.WriteLine(weekend + " - понедельник");
            Console.WriteLine("рабочий день");
        }
        else if (weekend == 2)
        {
            Console.WriteLine(weekend + " - вториник");
            Console.WriteLine("рабочий день");
        }
        else if (weekend == 3)
        {
            Console.WriteLine(weekend + " - среда");
            Console.WriteLine("рабочий день");
        }
        else if (weekend == 4)
        {
            Console.WriteLine(weekend + " - четверг");
            Console.WriteLine("рабочий день");
        }
        else if (weekend == 5)
        {
            Console.WriteLine(weekend + " - пятница");
            Console.WriteLine("рабочий день");
        }
        
    }
    else
    {
        Console.WriteLine("в неделе 7 дней! нужно вводить от 1 до 7.");
        Console.WriteLine("ппопробуйте снова.");
    }
    return "хорошего дня !" + "\n";
}