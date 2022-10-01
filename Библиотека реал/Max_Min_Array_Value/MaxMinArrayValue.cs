double[] numbers = { 3.1, 21.9, 7.0, 4.7, 22.07, 93.7777, 2.1, 71.4, 78.5, 24.3 };

int size = numbers.Length;
//double[] numbers = new double[size];/* массив double создан */

Console.WriteLine();
Console.WriteLine($"{size} <- размер массива ");

double max = numbers[0];//Int32.MinValue; 
double min = numbers[0];//Int32.MaxValue;
double max_ind = 0;
double min_ind = 0;

for (int i = 0; i < numbers.Length; i++)
{
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
            max_ind = i;
        }
        if (numbers[i] < min)
        {
            min = numbers[i];
            min_ind = i;
        }
    }
}
Console.WriteLine($"max значение  {max} -> у него индекс {max_ind} ");
Console.WriteLine($"мин. значение  {min} -> у него индекс {min_ind}");


