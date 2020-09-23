using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeWest
{
    public class QuoteGeneratorRonSwanson
    {

        public QuoteGeneratorRonSwanson(HttpClient client)
        {
            _client = client;
        }

        public string ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
        public HttpClient _client = new HttpClient();

        public string RonQuote()
        {
            var client = new HttpClient();
            var ronResponse = client.GetStringAsync(ronURL).Result;
            return JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']',' ').Trim();
            
        }
    }
}

