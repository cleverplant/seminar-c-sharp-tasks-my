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
        //int tmp = num[0];
        int size = num.Length;
        for (int i = 0; i < size - 1; i++)
        {
            int tmp = num[0];
            num[i] = num[i + 1];
            //num[0] = num[size - 1];
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
ShiftArrayLeft();