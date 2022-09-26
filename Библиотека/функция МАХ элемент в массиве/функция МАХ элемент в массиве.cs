

int[] ArrayMax = { 1, 8, 3, 2, 6 };

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
        index = index + 1; // <--- для ветки НЕТ
    }
    //index = index + 1; // <--- для ветки НЕТ
}
Console.WriteLine(max_ind);
Console.WriteLine(max);

/*
numbers = [1, 8, 3, 2, 6]
size = 5
index = 0
max = numbers[0]
min_ind = 0
while index < size:
    if numbers[index] > max:
       max =  numbers[index]
       max_ind = index
    index = index + 1 <--- для ветки НЕТ  
print('макс. значение: ' + str(max))
print('индекс(адрес) макс. значения в массиве: ' + str(max_ind))   
*/





