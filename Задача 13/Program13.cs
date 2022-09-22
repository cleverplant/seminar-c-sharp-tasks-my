/*
Задача 13: 
Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5 
78 -> третьей цифры нет 
3267432979 -> 6 
-------------------------------------------------------------------------
учитель внес дополнительное условие - число может быть боьше 3-х значного
решаем пока так (во втором варианте - будет просто математика):
.Substring(0, 3);  метод извлекающий подстроку (часть строки) из строки
грех не воспользоваться, ведь Console.ReadLine() работает в string.
.Length метод возвращает длину строки - зная длину строки задаем условие
Все равно получилось кашерно.
*/
Console.Write("введите число для сравнения: ");
string number = (Console.ReadLine());
int StringLength = number.ToString().Length;

// 1 блок 
if (StringLength > 3) // зная длину строки задаем условие - 
{
    Console.WriteLine("сенсей сказал, что можно вводить больше 3-х циферь ?"); // 
    Console.WriteLine("сенсей знает, что говорит ! вот решение :" + InRange(number));
}
else if (StringLength < 3)
Console.WriteLine("упс... что-то пошло не так! третьей цифры нет!");
else
{
    Console.WriteLine("вы ввели 3-х заначное число согласно инструкции " + InRange(number)); // 
}

// 2 блок 

int InRange(string arg)
{
    // int data = Convert.ToInt32(arg.Substring(0, 3));
    string ar = (arg.Substring(0, 3));
    int data = Convert.ToInt32(ar); 
    int result = data%10; 
    return result;
}
// int b = 645%10;
// Console.WriteLine(b);



