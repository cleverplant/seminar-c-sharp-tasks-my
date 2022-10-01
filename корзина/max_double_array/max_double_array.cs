
// double[] numbers = { 3, 21, 7, 04, 22, 93, 2, 71, 78, 24 };

Random vasya = new Random();
int size = vasya.Next(4, 6);
double[] numbers = new double[size];/* массив double создан */

Console.WriteLine();
Console.WriteLine($"{size} <- такой размер массива сейчас");



double max = numbers[0];
double min = numbers[0];
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
Console.WriteLine($"макс. значение  {max} ");
Console.WriteLine($"мин. значение  {min}");

Console.WriteLine($"макс. индекс  {max_ind} ");
Console.WriteLine($"мин. индекс  {min_ind}");



