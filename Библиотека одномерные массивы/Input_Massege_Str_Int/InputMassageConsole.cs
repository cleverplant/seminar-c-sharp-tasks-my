//------------- функция ввода сообщения -------------------

/* Описание: 
принимает на вход число в -> string -> (Console.ReadLine()) 
конвертирует в -> int -> и возвращает число в int
*/

int number = ReadInt("введите число: ");

int ReadInt(string ReadStr)
{
    Console.Write(ReadStr);
    return Convert.ToInt32(Console.ReadLine());
}

// string word = ReadString("введите слово: ");

// string ReadString(string Read)
// {
//     Console.Write(Read);
//     return (Console.ReadLine());
// }


string city = ReadStr("введите город: ");

string ReadStr(string Read = "London")
{
    Console.Write(Read);
    return (Console.ReadLine());
}
var City = ReadStr();
Console.WriteLine(City);



Console.Write("введите город на английском: ");
string DayWeek = (Console.ReadLine());

if (DayWeek != "")
{
    Console.WriteLine("строка не пустая");
    Console.WriteLine(DayWeek);
}
else if (DayWeek == "")
{
    Console.WriteLine("строка пустая");
    DayWeek = "London";
    Console.WriteLine(DayWeek);
}





