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
        else if (weekend > 0 && weekend < 6)
        {
            string Monday = " понедельник";
            string Tuesday = " вторник";
            string Wednesday = " среда";
            string Thursday = " четверг";
            string Friday = " пятница";
            string WorkingDay = "- сегодня рабочий день ! ";

            int N = weekend;
            int run = 1;
            while (run <= N - 1)
            {
                Console.WriteLine(run + "  - эти дни ты уже прожил (: ");
                run = run + 1;
            }
            if (run == 1)
                Console.WriteLine(run + " " + WorkingDay.Insert(9, Monday));
            else if (run == 2)
                Console.WriteLine(run + " " + WorkingDay.Insert(9, Tuesday));
            else if (run == 3)
                Console.WriteLine(run + " " + WorkingDay.Insert(9, Wednesday));
            else if (run == 4)
                Console.WriteLine(run + " " + WorkingDay.Insert(9, Thursday));
            else if (run == 5)
                Console.WriteLine(run + " " + WorkingDay.Insert(9, Friday));

        }

    }
    else
    {
        Console.WriteLine("в неделе 7 дней! нужно вводить от 1 до 7.");
        Console.WriteLine("попробуйте снова.");
    }
    return "хорошего дня :) !" + "\n";
}
