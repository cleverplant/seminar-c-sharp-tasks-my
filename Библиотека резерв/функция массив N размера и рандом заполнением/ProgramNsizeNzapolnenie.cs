
// функция ввода сообщения
int ReadMsg(string Msg)
{
    Console.Write(Msg);
    return Convert.ToInt32(Console.ReadLine());
}

int size = ReadMsg("введите размер массива: ");

int[] RandomArray = new int[size];

void PrintArray(int[] RandomArray)
{
for (int i = 0; i < RandomArray.Length; i++)
{
    RandomArray[i] = new Random().Next(1,9);
    Console.Write(RandomArray[i] + " ");
}
}
PrintArray(RandomArray);



// for (int i = 0; i < RandomArray.Length; i++)
// {
//     RandomArray[i] = new Random().Next(1,9);
//     Console.Write(RandomArray[i] + " ");
// }
