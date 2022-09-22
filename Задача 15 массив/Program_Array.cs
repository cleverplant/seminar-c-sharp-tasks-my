/* 
ВозвращаемыйТипДанных ИмяМетода([ТипДанных1 ИмяАргумента1, ... ])
|          int       |   Max   |    (int   |      arg1,   |   int arg2, | int arg3)   
*/

Console.Write("введите номер дня недели от 1 до 7: ");
int DayWeek = Convert.ToInt32(Console.ReadLine());

string Monday = "понедельник";
string Tuesday = "вторник";
string Wednesday = "среда";
string Thursday = "четверг";
string Friday = "пятница - международный день пива :) ";
string Saturday = "суббота - сегодня выходной! сегодня будет праздник!";
string Sunday = "воскресенье - соберись! завтра понедельник";

//                     0  1  2  3  4  5  6
int[] ArrayWeek = { 1, 2, 3, 4, 5, 6, 7 };

//                       0        1         2          3        4       5        6 <---------| 
string[] ArrayDays = { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };//   |
// 
if (DayWeek > 0 && DayWeek < 8)
{
    int N = DayWeek - 1; // нам нужен индекс последнего элемента массива, а он будет = 6, а не = 7
    int run = 0;
    while (run < N)
    {
        Console.WriteLine(ArrayWeek[run] + " - этот день ты уже прожил");
        Console.WriteLine(ArrayDays[run] + " - вычеркиваем");
        run = run + 1;
    }
    Console.WriteLine("_________________________________");
    Console.Write(ArrayWeek[run] + "  -> сегодня ");
    Console.WriteLine(ArrayDays[run]);
    Console.WriteLine("_________________________________");
}
else
{
    Console.WriteLine("_________________________________");
    Console.WriteLine("на Земле, в неделе 7 дней! нужно вводить от 1 до 7.");
    Console.WriteLine("вернитесь на Землю и попробуйте снова.");
    Console.WriteLine("_________________________________");
}


