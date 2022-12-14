/*
класс WebRequest - отправка запроса
Класс WebResponse - получение ответа на запрос
*/

//Перейдем в class Program Weather.cs
using Newtonsoft.Json.Linq;

namespace OpenweathermapApi
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6). Cоздаем запрос к веб порталу: В созданную переменную var request нужно передать адрес нашего вебсайта
            var request = new GetRequest($"http://api.openweathermap.org/data/2.5/weather?q=London,uk&units=metric&APPID=0a9b051464990ec3facc0b5dba7c7c73");
            
            request.Run();// 7). Чтобы выполнить данный запрос, нужно у объекта request выполнить метод RUN

            var response = request.Response; //


            // 8). нам нужно обработать полученный ответ. Для этого создаем переменную в которую пишется парсинг:
            var json = JObject.Parse(response);// на этом этапе надо сделать запрос и проверить ответ в программе fiddler

            /* нужно обратить внимание, что переменные в строке JSON имеют "вложенность", 
            например параметр humidity или temp вложены в main, поэтому main["humidity"]; или main["temp"];, но 
            сначала нужно сделать запрос JSON к глвному параметру json["main"];*/

            var name = json["name"]; // 9). из переменной var json вытаскиваем нужные нам значения парсинга:
            var main = json["main"];
            var wind = json["wind"];

            var temp = main["temp"];
            var humidity = main["humidity"];
            var pressure = main["pressure"];
            var speed = wind["speed"];
            {
                /* здесь значения которые вытащили из формата JSON 
                 переводим в формат строки-получаем читабельный текст */
                Console.WriteLine();
                Console.WriteLine($"в городе: {name}");
                Console.WriteLine($"температура: {temp}°C - влажность: {humidity}%");
                Console.WriteLine($"скорость ветра: {speed}м/с - давление: {pressure}φ - фиг знает в чем");
                Console.WriteLine();
            }
        }
    }
}
/*    Т.З. 
      1. разбиваем API на части, изучаем библиотеку и  
      2. даем возможность пользователю ввести значения ГЕО т.е. свой город. 
      3. изучаем бибку и переводим на русский язык
      4. делаем защиту от дурака, очистить концевые пробелы, 
        привести вводимую строку к формату понятному сервисом openweathermap 
*/

