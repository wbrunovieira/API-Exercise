using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeWest
{
    public class QuoteGeneratorKanye
    {
        public QuoteGeneratorKanye(HttpClient client)
        {
            _client = client;
        }

        public string kanyeURL = "https://api.kanye.rest/";
        public HttpClient _client = new HttpClient();

        public string KanyeQuote()
        {
            var client = new HttpClient();
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            return JObject.Parse(kanyeResponse).GetValue("quote").ToString();
        }
    }
}
