//------------- функция ввода сообщения -------------------

/* Описание: 
принимает на вход число в -> string -> (Console.ReadLine()) 
конвертирует в -> int -> и возвращает число в int
*/

int number = ReadInt("введите значение: ");

int ReadInt(string ReadStr)
{
    Console.Write(ReadStr);
    return Convert.ToInt32(Console.ReadLine());
}
