//------------- функция ввода заполнения массива случайными DOUBLE значениями -------------------

void PrintRandomArray(int MinSize = 1, int MaxSize = 9) 
{
    Random vasya = new Random();
    int size = vasya.Next(MinSize, MaxSize);
    double[] numbers = new double[size];/* массив double создан */

    Console.WriteLine();
    Console.WriteLine($"{size} <- такой размер массива сейчас");
    Console.WriteLine();

    // ---------------------------------------------------------------------------

    FillArray(numbers); // метод FillArray(); надо вызывать здесь ->           
    PrintArray(numbers); // где в контексте есть вызываемый массив - numbers !!!

    //-------------------------------------------------------------------------------------

    void FillArray(double[] num) /* ЭТО МАССИВ НА ЗАПОЛНЕНИЕ */
    {
        Random mahmud = new Random();
        for (int i = 0; i < num.Length; i++) //num.Length -длина массива = size 
        {
            num[i] =  Math.Round((mahmud.NextDouble() * 20), 2);// сама функция возвращает от 0.0 до 1.0, 
        }                                                      // поэтому нужно домножать на произвольное число,
    }                                                         // чтобы расширить диапозон                   
//-------------------------------------------------------------------------------------

    void PrintArray(double[] numb)
    {
        for (int i = 0; i < numb.Length; i++)     
        {                                  
            Console.Write(numb[i] + "  ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}
PrintRandomArray();



// корзина\проверка double random\double random.cs

// Random rand = new Random();//сама функция возвращает от 0.0 до 1.0,
// double mas = rand.NextDouble() * 20; //поэтому нужно домножать на произвольное число,
// Console.WriteLine(mas);//чтобы расширить диапозон

// double x = Math.Round(mas, 2); // округление до нужного знака после запятой
// Console.WriteLine(x);

// double massege = Math.Round((rand.NextDouble() * 20), 2);
// Console.WriteLine(massege);
