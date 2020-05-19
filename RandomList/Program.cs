using System;

namespace RandomList
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomList strings = new RandomList()
            {
                new string("Henny"),
                new string("Heidi"),
                new string("Kari"),
                new string("Mari"),
            };

            Console.WriteLine(strings.RandomString());
        }
    }
}
