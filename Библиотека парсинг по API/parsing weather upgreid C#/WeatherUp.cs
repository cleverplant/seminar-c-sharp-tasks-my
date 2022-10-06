/* объект класс WebRequest - отправка запроса
   объект класс WebResponse - получение ответа на запрос
*/
using Newtonsoft.Json.Linq;
using System;

namespace OpenweathermapApi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите город на русском: ");
            string CITY = (Console.ReadLine());
            if (CITY != "")
            {
                Console.WriteLine("погода в городе: ");
                Console.WriteLine(CITY);
            }
            else if (CITY == "")
            {
                Console.WriteLine("по умолчанию погода в: ");
                CITY = "Москва";
                Console.WriteLine(CITY);
            }

            string APPID = "0a9b051464990ec3facc0b5dba7c7c73";
            string URL_BASE = "http://api.openweathermap.org/data/2.5/";
            //string CITY = "London";


            var request = new GetRequest($"{URL_BASE}weather?q={CITY}&units=metric&APPID={APPID}&lang=ru");

            request.Run();

            var response = request.Response;

            var json = JObject.Parse(response);

            var name = json["name"];
            var main = json["main"];
            var wind = json["wind"];

            var temp = main["temp"];
            var humidity = main["humidity"];
            var pressure = main["pressure"];
            var speed = wind["speed"];
            int mmhg = (Convert.ToInt32(pressure) * 750) / 1000;

            {
                Console.WriteLine();
                Console.WriteLine($"в городе: {name}");
                Console.WriteLine($"температура: {temp} °C - влажность: {humidity} %");
                Console.WriteLine($"скорость ветра: {speed} м/с");
                Console.WriteLine($"давление: {pressure} hPa или {mmhg} mm Hg");
                 Console.WriteLine();
                Console.WriteLine($"Оптимальными метеоусловиями считаются:");
                Console.WriteLine($"температура: +20-24°С - влажность: 40-60%");
                Console.WriteLine($"скорость ветра: 0,1-0,5 м/с - давление воздуха: 760 mm Hg");

                Console.WriteLine();
            }
        }
    }
}
/*    Т.З. 
    +  1. разбиваем API на части, изучаем библиотеку и  
    +  2. даем возможность пользователю ввести свой город. 
    +  3. изучаем бибку и переводим на русский язык
    +  4. делаем защиту от дурака, очистить концевые пробелы, 
        привести вводимую строку к формату понятному сервисом openweathermap 
        - не понадобилось - сервис позаботился о дураках.
        
    ?   Можно перекусить и посмотреть Дискавери и спать...
аа чуть не забыл! еще почитать про реквест и респонс...завтра.

*/

