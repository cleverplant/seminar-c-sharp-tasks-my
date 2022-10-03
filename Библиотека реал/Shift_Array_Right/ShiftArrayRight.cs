/* функция массив вправо. 
 
*/
void ShiftArrayRight()
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
        int size = num.Length;
        int tmp = num[size - 1];
        for (int i = size - 1; i > 0; --i)
        {
           num[i] =  num[i - 1];
        }
        //num[0] = 55;
        num[0] = tmp;
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


