/* функция массив вправо. 
 НЕ ПОЛУЧАЕТСЯ - НАДО СПРОСИТЬ ПОЧЕМУ
*/

void ShiftArrayRight()
{
    {
        Console.WriteLine();
        int[] numbers = { 3, 21, 7, 4, 22, 93, 2, 71 };// 
        int size = numbers.Length;
        //int[] numbers = new int[sise];/* массив создан */

        Console.WriteLine($"{size} <- размер массива");
        Console.WriteLine();

        PrintArray(numbers);
        ArrayRight(numbers);
        PrintArray(numbers);

    }
    void ArrayRight(int[] num) /* массив  */
    {
        int size = num.Length;
        //int tmp = num[0];
        for (int i = size - 1; i > 0; i--)
        {
            int tmp = num[0];
            num[i] = num[i - 1];
            num[0] = tmp;
                                   //num[0] = num[size - 1];                // 71 -> 3
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
ShiftArrayRight();