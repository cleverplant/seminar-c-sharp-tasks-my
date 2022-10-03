/* функция массив влево. 
 НЕ ПОЛУЧАЕТСЯ - НАДО СПРОСИТЬ ПОЧЕМУ
*/
void ShiftArrayLeft()
{
    {
        Console.WriteLine();
        int[] numbers = { 3, 21, 7, 4, 22, 93, 2, 71 };// 
        int sise = numbers.Length;
        //int[] numbers = new int[sise];/* массив создан */

        Console.WriteLine($"{sise} <- размер массива");
        Console.WriteLine();

        PrintArray(numbers);
        ArrayRight(numbers);
        PrintArray(numbers);

    }
    void ArrayRight(int[] num) /* массив  */
    {
        int tmp = num[0];
        int size = num.Length;
        for (int i = 0; i < size - 1; i++)
        {
            num[i] = num[i + 1];

        }
        //num[size - 1] = 55;
        num[size - 1] = tmp;
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
ShiftArrayLeft();

// static void ShiftElements(int[] arr)
// {
//     int prev= arr[0];
//     int next;
//     for(int i = 0; i < arr.Length - 1; ++i)
//     {
//         next = arr[i+1];
//         arr[i+1] = prev;
//         prev = next;
//     }
//     arr[0] = prev;

// это решение из интернета и оно мне нравится больше, потому что для тупых
