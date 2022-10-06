using System;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace WeatherConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=London&units=metric&uk&APPID=0a9b051464990ec3facc0b5dba7c7c73";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            //HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebResponse.GetResponse();

            string response;
            
            //using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream())) ;
            {
             //   response = streamReader.ReadToEnd();
            }
           // WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);

            //Console.WriteLine("Temperature in {0}: {1} Celsium", weatherResponse.Name, weatherResponse.Main.Temp);
        }
    }
}