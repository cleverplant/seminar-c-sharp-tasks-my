

// Random vasya = new Random();
// int num = vasya.Next(10, 1000);
// Console.WriteLine(num);

//Random rand = new Random(DateTime.Now.Millisecond);
// Random rand = new Random();
// double[] mas = new double[20];
// for (int i = 0; i < mas.Count(); i++)
//     //вернет случайные дробные от 0 до 20
//     //сама функция возвращает от 0.0 до 1.0, поэтому нужно домножать на произвольное число,
//     //чтобы расширить диапозон
//     mas[i] = rand.NextDouble() * 20;

Random rand = new Random();
double mas = rand.NextDouble() * 20; //сама функция возвращает от 0.0 до 1.0, поэтому нужно домножать на произвольное число,
Console.WriteLine(mas);//чтобы расширить диапозон


double x = Math.Round(mas, 2);
Console.WriteLine(x);

double massege = Math.Round((rand.NextDouble() * 20), 2);
Console.WriteLine(massege);

