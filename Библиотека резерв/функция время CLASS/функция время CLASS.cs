// Объявление класса

App.ShowCurrentDate(); // инструкции верхнего уровня должны 
                       //предшествовать пространству имен
Apple.Greeting();

class App
{
    // Определение метода
    public static void ShowCurrentDate()
    {
        // Класс со свойством для получения текущего времени
        var currentDate = DateTime.Now;
        var text = $"Today is: {currentDate}";
        Console.WriteLine(text);
    }
}
// Вызов метода
// Обязательно указывать имя класса
//App.ShowCurrentDate(); // => "Today is: 09.12.2021 10:52:13"

class Apple
{
    public static void Greeting()
    {
        Console.WriteLine("Winter is coming");
    }
}



