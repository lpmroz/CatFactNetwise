using CatFactNetwise.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CatFactNetwise.Services
{
    public class CatFactService : ICatFactService
    {
        public async Task<String> GetFact()
        {
            
            var parametr = new ParameterConnect();
            var message = await parametr.HttpClient.GetAsync(parametr.BaseAdress);
            var result = await ReadFact(message);
            
            return result;
        }

        public async Task<string> ReadFact(HttpResponseMessage message)
        {
            var fact = await message.Content.ReadAsStringAsync();
             var result = DeserializeFact(fact);
            return result;
        }

        public string DeserializeFact(string message)
        {
            var result = JsonConvert.DeserializeObject<JObject>(message).First.First.ToString();
            return result;
        }


    }
}
