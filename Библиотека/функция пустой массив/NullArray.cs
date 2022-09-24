/* 
ВозвращаемыйТипДанных ИмяМетода([ТипДанных1 ИмяАргумента1, ... ])
|          int       |   Max   |    (int   |      arg1,   |   int arg2, | int arg3)   

https://www.youtube.com/watch?v=1D3SAsp1M9s&list=RDCMUCQfwKTJdCmiA6cXAY0PNRJw&index=5

*/
//                     0  1  2  3  4  5  6
// int[] ArrayWeek = { 1, 2, 3, 4, 5, 6, 5 };


int[] ArrayWeek = new int[7];
Console.WriteLine(ArrayWeek.Length);

int N = ArrayWeek.Length; // это если нам нужен индекс последнего элемента массива то -1 надо
                          // а если нужно количество элементов массива то -1 не надо 
    int run = 0;
    while (run < N)
    {
        Console.Write(ArrayWeek[run] + " ,");
        
        run = run + 1;
    }
    Console.WriteLine("всего элементов -> " + run);
    Console.WriteLine("последний  -> " + ArrayWeek[run - 1]);

// void PrintArray(int[] ArrayWeek)// <-в качестве аргумента здесь массив.

// {
//     int count = ArrayWeek.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(ArrayWeek[position]);
//         position++;
//     }
// }
    
  



// for (int i = 0; i < N; ++i)

