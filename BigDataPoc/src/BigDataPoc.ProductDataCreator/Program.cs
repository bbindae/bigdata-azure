using System;

namespace BigDataPoc.ProductDataCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for(var i = 0;i<1000;i++)
            {

            }
        }

        static ProductEvent CreateProductEvent()
        {
            var e = new ProductEvent()
            {

            }
        }

        public DateTime GetRandomDate(int max)
        {
            var random = new Random();

        }
        public static int RandomNumber(int min, int max)
        {
            var random = new Random();
            return random.Next(min, max);
        }

        public static char RandomChar()
        {
            var n = RandomNumber(97, 122);
            var c = Convert.ToChar(n);
            return c;
        }

        public string RandomString(int size, bool lowerCase)
        {
            var random = new Random();
            var ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));

        }
    }

    public class ProductEvent
    {
        public string ShortSku { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid UserSessionId { get; set; }
        public EventSource EventSource { get; set; }
    }

    public enum EventSource
    {
        SortPage = 1,
    }


}
