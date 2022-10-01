



int[] Array = { 1, 2, 3, 4, 5, 6, 7 };
int N = Array.Length;

for(int i = 0; i < N/2; ++i)
{
    int tmp = Array[N - 1 -i];
    Array[N - 1 -i] = Array[i];
    Array[i] = tmp;
    Console.Write(Array[i] + " ,"); 
}

// print('----------------------')  
// N = 7
// arr = [1, 2, 3, 4, 5, 6, 7]
// i = 0
// while (i < N/2):
//     tmp = arr[(N - 1) - i ]
//     arr[(N - 1) - i ] = arr[ i ]
//     arr[ i ] = tmp
//     i = i + 1 
// print(arr)
