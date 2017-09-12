using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerTask.Interfaces;
using ServerTask.Task_Value;
using ServerTask.Json;
using RestSharp;

namespace ServerTask.WebClient
{
    class TaskWeb : Interfaces.IWebClient
    {
        public async Task<List<Headers>> GetHeadersListAsync()
        {
            string url = "http://httpbin.org/headers";
            var client = new RestClient(url);
            var request = new RestRequest("resource/{id}", Method.POST);
            request.AddHeader("header","value");
            IRestResponse response = client.Execute(request);
            IParse parser = new JsonParser();
            return await parser.ParseStringAsync<List<Headers>>(response.Content);
        }
    }
}
