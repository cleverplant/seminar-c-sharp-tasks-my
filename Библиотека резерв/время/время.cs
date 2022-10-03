
//App.ShowCurrentDate();

namespace TimeIsIt
{
    class App
    {
        // Определение метода
        public static void ShowCurrentDate()
        {
            // Класс со свойством для получения текущего времени
            var currentDate = DateTime.Now;
            var text = $"Today is: {currentDate}";
            Console.WriteLine(text);
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
            Console.WriteLine(DateTime.Now.ToString("dd MMMM yyyy")); 
        }
    }
}
// http://plssite.ru/csharp/csharp_get_current_time_acticle.html

// void time()
// {
//     var currentDate = DateTime.Now;
//     var text = $"Today is: {currentDate}";
//     Console.WriteLine(text);

//     Console.WriteLine(DateTime.Now.ToString("HH:mm:ss")); //Выводим только время

//     Console.WriteLine(DateTime.Now.ToString("dd MMMM yyyy")); 
//     //Выводим дату, выводится название месяца а не его номер

//     // //Чтобы программа сразу же не закрылась
//     // Console.ReadKey();
// }
// time();




