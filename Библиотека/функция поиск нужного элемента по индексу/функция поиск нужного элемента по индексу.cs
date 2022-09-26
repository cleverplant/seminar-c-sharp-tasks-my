// пока не делал
Console.WriteLine("");

//              0  1  2  3  4
int[] Array = { 1, 8, 3, 2, 6 };
int p = 2;// это значение нужно вводить в консоль для сравнения
int N = Array.Length - p;
int max = Array[0];
int max_ind = 0;

{
    for (int i = 0; i < N; i = i + 1)

    {
        if (Array[i] > max)
            max = Array[i];
        max_ind = i;
        i = i + 1;
    }
}
Console.WriteLine(max_ind);
Console.WriteLine(max);


