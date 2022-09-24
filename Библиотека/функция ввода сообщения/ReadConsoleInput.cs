// функция ввода сообщения

// принимает на вход число в -> string -> (Console.ReadLine())  
// конвертирует в -> int -> и возвращает число в int

// int number = ReadConsoleInput("Введите значение: ");

int ReadConsoleInput(string StringNumber)
{
    Console.Write(StringNumber);
    return Convert.ToInt32(Console.ReadLine());
}
