
int[] numbers = { 2, 5, 13, 7, 6, 4 };

int size = numbers.Length;
int index = 0;
int max = numbers[0];
int max_idx = 0;

while (index < size)
{
    {
    {
        if (numbers[index] > max)

            max = numbers[index];
        max_idx = index;
        numbers[max_idx] = numbers[size - 1];
        numbers[size - 1] = max;
        Console.WriteLine(numbers[max]);
        index = index + 1;
    }
    numbers[max_idx] = numbers[size-1];
    numbers[size-1] = max;
    }
}



// Console.WriteLine(max_ind);
// Console.WriteLine(max);

//------------------------------------------------------------------------

// numbers = [2, 5, 13, 7, 6, 4]
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



