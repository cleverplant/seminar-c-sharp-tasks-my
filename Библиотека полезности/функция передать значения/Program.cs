
// Описание
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Вызов
Method21(msg: "Текст", count: 4); // <---------- значения передаются через : , а не через =
Method21(count: 4, msg: "новый текст");//<-------

