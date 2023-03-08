using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Exchange.ConsoleApp
{
    public class CSharpExample
    {

        public static void Main(string[] args)
        {
            var url = "https://api.collectapi.com/economy/cripto";
            var client = new RestClient();
            var request = new RestRequest(url, Method.Get);
            request.AddHeader("authorization", "apikey 0OXCcgxI2PQ96HejAR5jiL:1PECTbGb9iBqD4BUvzQgCE");
            request.AddHeader("content-type", "application/json");
            var response = client.Execute(request);

            var personel = JsonConvert.DeserializeObject(response.Content);
            Console.WriteLine(personel);
        }

    }
}

