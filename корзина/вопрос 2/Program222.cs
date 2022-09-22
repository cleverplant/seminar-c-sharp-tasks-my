// Console.Write("введите число для сравнения: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int number =10;
// test1(number);
// int test1(int n = 0)
// {
//     if (n == 10)
//         return 1;
//     if (n == 11)
//         return 2;
//     if (n == 12)
//         return 3;    
// }
// Console.Write(test1());

int number =10;
test(number);
int test(int n = 0)
{
    if (n >= 10)
        return 0;
    else if (n < 10)
        return n;
    else
        return 100;
}
Console.Write(test());