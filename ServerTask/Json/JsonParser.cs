using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerTask.Interfaces;
using Newtonsoft.Json;

namespace ServerTask.Json
{
    class JsonParser : IParse
    {
        public async Task<T> ParseStringAsync<T>(string response)
        {
            return await Task.Factory.StartNew(() => JsonConvert.DeserializeObject<T>(response));
        }
    }
}
