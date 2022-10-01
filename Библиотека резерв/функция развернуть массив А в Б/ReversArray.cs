
// int[] ArrayA = new int[7];

int[] ArrayA = { 1, 2, 3, 4, 5, 6, 7 };
int N = ArrayA.Length;
Console.WriteLine("size A = " + ArrayA.Length);
int[] ArrayB = new int[N];
Console.WriteLine("size B = " + ArrayB.Length);

int i = 0;
while (i < N)
{
    ArrayB[i] = ArrayA[N - 1 - i];
    Console.WriteLine(" A -> " + ArrayA[i] + " ,");
    Console.WriteLine(" B -> " + ArrayB[i] + " ,");
    i = i + 1;
}
// Console.WriteLine("всего элементов -> " + i);
// Console.WriteLine("последний  -> " + ArrayA[i - 1]);
// Console.WriteLine("всего элементов -> " + i);
// Console.WriteLine("последний  -> " + ArrayB[i - 1]);



