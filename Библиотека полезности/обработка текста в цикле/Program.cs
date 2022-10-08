/*
Работа с текстом
string s = "qwerty"
            012
s[3] // r

Дан текст. В тексте нужно все пробелы заменить черточками, 
маленькие буквы “к” заменить большими “К”,
a большие “С” заменить маленькими “с”.
Ясна ли задача?
*/
string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string newText = Replace(text, ' ', '|');

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;//<--- это значит пустая строка ""

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) 
        result = result + $"{newValue}";
        
        else result = result + $"{text[i]}";
    }

    return result;
}

Console.WriteLine();
Console.WriteLine(newText);

Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

Console.WriteLine();


