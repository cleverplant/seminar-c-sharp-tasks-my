/*
 задаёт массив из N элементов и выводит их на экран.
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]
*/

int lenArray = ReadConsoleInput("введите длинну массива: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}


// Библиотека\функция ввода сообщения
int ReadConsoleInput(string StringNumber)
{
    Console.Write(StringNumber);
    return Convert.ToInt32(Console.ReadLine());
}
