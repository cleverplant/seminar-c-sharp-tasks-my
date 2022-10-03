/* функция перевоачивает массив. 
функция использует два массива. во второй массив записывается реверс первого.
Для практического применения нужно вынести -> Random vasya = new Random(); за пределы этой функции 
или присвоить входному параметру void FillArrayA(int[] num) свой массив, 
предварительно удалив int[] numbers1 = new int[sise]; 
*/

void Revers()
{
    {
        int sise = 8;
        int[] numbers1 = new int[sise];/* массив 1 создан */
        int[] numbers2 = new int[sise];/* массив 2 создан */
        Console.WriteLine($"{sise} <- размер массива");

        FillArrayA(numbers1);
        PrintArrayA(numbers1);
        FillArrayB(numbers1, numbers2);
        PrintArrayB(numbers2);


        void ReversArray() // эта функция для понимания и для красоты
        {
            int MaxIndex = numbers1.Length - 1;
            for (int i = 0; i < numbers1.Length; i++)
            {
                Console.WriteLine(numbers1[i] + " - " + numbers1[MaxIndex - i] + " ");
            }
        }
        ReversArray();

    }
    void FillArrayA(int[] num) /* массив 1 заполняем рандомом */
    {
        Random vasya = new Random();
        for (int i = 0; i < num.Length; i++)
        {
            num[i] = vasya.Next(1, 10);
        }
        Console.WriteLine();
    }

    void PrintArrayA(int[] numb)
    {
        for (int i = 0; i < numb.Length; i++)
        {
            Console.Write(numb[i] + ", ");
        }
        Console.WriteLine();
    }

    void FillArrayB(int[] num1, int[] num2) /* массив 2 заполняем массивом 1 */
    {
        int MaxIndex = num1.Length - 1;
        for (int i = 0; i < num2.Length; i++)
        {
            num2[i] = num1[MaxIndex - i];
        }
        Console.WriteLine();
    }

    void PrintArrayB(int[] numb)
    {
        for (int i = 0; i < numb.Length; i++)
        {
            Console.Write(numb[i] + ", ");
        }
        Console.WriteLine();
    }

}
Revers();