
int[] ArrayMax = { 2, 5, 13, 7, 6, 4 };

int size = ArrayMax.Length;
int index = 0;
int max = ArrayMax[0];
int max_ind = 0;

while (index < size)
{
    {
        if (ArrayMax[index] > max)

            max = ArrayMax[index];
            max_ind = index;
        index = index + 1; 
    }
}   
Console.WriteLine(max_ind);
Console.WriteLine(max);


// numbers = [2, 5, 13, 7, 6, 4]
// elem_massiva = numbers[4] 
// size = 6
// index = 0
// max_idx = 0
// max = numbers[max_idx]

// while index < size:
//   if numbers[index] > max:
//     max_idx = index
//     max = numbers[index]
//   index = index + 1

// numbers[max_idx] = numbers[size-1]
// numbers[size-1] = max
// print(numbers)
// print(numbers[4])
// print('''вот так получаем само значение элементе массива
// - содержимое ячейки по адресу: '''+ str(numbers[4]))


