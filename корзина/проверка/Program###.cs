// здесь прросто проверяю работу операторов
//            1            5            4            3 
// if (number[0] == number[4] && number[1] == number[3])




// Console.Write("введите число : ");
// int number = Convert.ToInt32(Console.ReadLine());
// number = Math.Abs(number);

//                    0  1  2  3  4
int number = 24975;// 1  4  9  7  5;
if (number > 99999)
{
    while (number > 99999)
    {
        number /= 10;
        Console.WriteLine("выкидываем последнюю цифру: " + number);
    }
    Console.WriteLine("[ 0 ]  числа: " + (number / 10000));
    Console.WriteLine("[ 1 ]  числа: " + (number % 10000)/1000);
    Console.WriteLine("[ 2 ]  числа: " + (number % 1000)/100);
    Console.WriteLine("[ 3 ]  числа: " + (number % 100)/10);
    Console.WriteLine("[ 4 ]  числа: " + number % 10/1);
}

else
{
    Console.Write("ошибка");
}

















//               0  1  2  3  4
// int a = 14235;// 1  4  2  3  5;

// int b = (a/10000);// 1
// int c  = (a/1000); //2
// int d  = (a/100); //
// int e  = (a); //
// int f  = (a  );

// Console.WriteLine("b " + b);
// Console.WriteLine("c " + c%10);
// Console.WriteLine("d " + d%100);
// Console.WriteLine("e " + e%1);
// Console.WriteLine("f " + e%10); // 3


// int a = 16%2;
// int b = 21%2;
// Console.WriteLine(a);
// Console.WriteLine(b);

// int x = 99%3;//       в сумме 9        в остатке 2
// int y = 11%3;//       | 3 || 3 || 3 |      2
// Console.WriteLine(x);
// Console.WriteLine(y);




