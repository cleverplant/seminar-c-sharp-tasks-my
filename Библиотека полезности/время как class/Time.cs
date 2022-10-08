namespace Timing
{
    class TimeClass
    {
        public static void Clock()
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
        }
        public static void Data()
        {
            Console.WriteLine(DateTime.Now.ToString("dd MMMM yyyy"));
        }

        public static void Text()
        {
            Console.WriteLine("User! Да настигнет тебя Дзеннн!");
            Console.WriteLine("Время пошло...");
        }
    }
}


