/*
класс WebRequest - отправка запроса
Класс WebResponse - получение ответа на запрос
*/
using System.Net;


namespace OpenweathermapApi
{
    public class GetRequest
    {
        HttpWebRequest _request;
        string _address;

        //5). Создадим метод Response: в этот метод будем записывать ответ от вебсервера
        public string Response { get; set; }// ---> !!! Перейдем в class Program Weather.cs !!! 

        // Для выполнения Get запроса создаем новый класс - public class GetRequest 
        public GetRequest(string address)// 1). Создадим конструктор класса в который передаем строку класса:
        {
            _address = address;// 
        }

        public void Run()//  2). Создадим паблик метод Run. Этот метод в нужный момент запускает созданный запрос
        {
            //создаем запрос: _request = WebRequest.Create();
            _request = (HttpWebRequest)WebRequest.Create(_address);// 3).  создадим объект запроса - _request в HttpWebRequest

            _request.Method = "Get";// данный запрос является Get запросом. 

            try
            {   // 4). Создадим объект ответа вебсервера:
                HttpWebResponse response = (HttpWebResponse)_request.GetResponse();
                var stream = response.GetResponseStream();

                if (stream != null) Response = new StreamReader(stream).ReadToEnd();
            }
            catch (Exception)
            {
            }
        }
    }
}
// Перейдем в class Program Weather.cs -> Библиотека парсинг по API\parsing weather C#\Weather.cs


