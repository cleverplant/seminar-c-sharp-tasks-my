

/*

!!!  ПОТОМ ОФОРМЛЮ С ВОЙЙДОМ И ПРИНЭРЕЕЯМИ - РЕШЕНИЕ ДОРОГО КАК ПАМЯТЬ - И ОООЧЕНЬ ПОНЯТНОЕ !!! 

*/
// int[] ArrayA = new int[7];

int[] ArrayA = { 1, 2, 3, 4, 5, 6, 7 };
int N = ArrayA.Length;
Console.WriteLine("size A = " + ArrayA.Length);
int[] ArrayB = new int[N];
Console.WriteLine("size B = " + ArrayB.Length);

int i = 0;
int LastIndex = N - 1;
while (i < N)
{
    {
    ArrayB[i] = ArrayA[i]; // ArrayA[i + 2];
    Console.WriteLine(" A -> " + ArrayA[i] + " ,");
    Console.WriteLine(" B -> " + ArrayB[i] + " ,");
    i = i + 1;
}
}





