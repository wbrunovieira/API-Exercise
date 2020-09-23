using System;
using System.Net.Http;

namespace KanyeWest
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();

            var k = new QuoteGeneratorKanye(client);
            var r = new QuoteGeneratorRonSwanson(client);

            Console.WriteLine("A conversation between Kanye West and Ron Swanson.");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------------");

            for (int i = 0; i < 10; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine("Ron Swanson: ");
                    Console.WriteLine(r.RonQuote());
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Kanye West: ");
                    Console.WriteLine(k.KanyeQuote());
                    Console.WriteLine("");

                }

            }
        }
    }
}
