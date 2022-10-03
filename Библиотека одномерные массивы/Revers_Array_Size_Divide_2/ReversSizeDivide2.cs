/* функция перевоачивает массив. 
функция использует один массив. 
*/

void ReversSizeDivide2()
{
    {
        Console.WriteLine();
        int[] numbers = { 3, 21, 7, 4, 22, 93, 2, 71 };// 
        int sise = numbers.Length;
        //int[] numbers = new int[sise];/* массив создан */

        Console.WriteLine($"{sise} <- размер массива");
        Console.WriteLine();

        PrintArray(numbers);
        ReversArray(numbers);
        PrintArray(numbers);

    }
    void ReversArray(int[] num) /* массив заполняем рандомом */
    {
        int MaxIndex = num.Length - 1;// -> ( num.Length - 1 - i )
        for (int i = 0; i < num.Length / 2; i++)
        {
            int tmp = num[i];
            num[i] = num[MaxIndex - i];// -> ( num.Length - 1 - i )
            num[MaxIndex - i] = tmp;

        }
        Console.WriteLine();
    }

    void PrintArray(int[] numb)
    {
        for (int i = 0; i < numb.Length; i++)
        {
            Console.Write(numb[i] + ", ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
ReversSizeDivide2();
