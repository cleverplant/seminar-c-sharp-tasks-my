namespace Timing
{
    class TimeClass
    {
        public static void Clock()
        {
            Console.WriteLine();
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));

        }
        public static void Data()
        {
            Console.WriteLine(DateTime.Now.ToString("dd MMMM yyyy"));
        }
    }
}


